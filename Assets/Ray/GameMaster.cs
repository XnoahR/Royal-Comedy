using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum GameState{
    START,
    playerTurn,
    enemyTurn,
    WIN,
    LOSE
}

public class GameMaster : MonoBehaviour
{
    public static int totalTurns = 0;
    public static int playerPace = 0;
    public static int enemyPace = 0;
    public static GameState currentState;
    public static bool skipTurns = false;
    //array of objects card
    public GameObject[] cards = new GameObject[5];
    public GameObject panelOverlay;
    public Canvas canvas;
    public Player player;
    public Enemy enemy;
    public TMP_Text turnText;
    // Start is called before the first frame update
    void Start()
    {
        currentState = GameState.START;
        StartCoroutine(BattleStart());
    }

    public IEnumerator BattleStart(){
        //battle begin! setup arena, dll.
        turnText.text = "GAME START!";
        totalTurns = 0;
        enemyPace = 0;
        playerPace = 0;
        yield return new WaitForSeconds(2f);
        currentState = GameState.playerTurn;
        StartCoroutine(PlayerTurn());
    }

    public IEnumerator PlayerTurn(){
        player._Generate_Card();
        // foreach(Skills skill in SkillContainer.skillObjects){
        //     if (skill.cooldownDiff > 0){
        //         skill.cooldownDiff -= 1;
        //     }
        //     else{
        //         skill.isCooldown = false;
        //     }
        // }

        _Check_Cooldown();

        //add play animation here
        yield return new WaitUntil(() => Player.hasClicked);
        Debug.Log("Player clicked. Coroutine continues.");

        playerPace += 1;
        totalTurns += 1;

        if (player.funnyBar >= 100) {
            currentState = GameState.WIN;
            StartCoroutine(GameWin());
        }
        else if (skipTurns){
            Debug.Log("keskipk");
            skipTurns = false;
            currentState = GameState.playerTurn;
            Player.hasClicked = false;
            StartCoroutine(PlayerTurn());
        }
        else {
            currentState = GameState.enemyTurn;
            Enemy.hasMoved = false;
            turnText.text = "Enemy Turn";
        }

    }
    public IEnumerator EnemyTurn(){
        enemyPace += 1;
        totalTurns += 1;
        yield return new WaitForSeconds(0.5f);
        if (enemy.funnyBar >= 100) {
            currentState = GameState.LOSE;
            StartCoroutine(GameLose());
        }
        else if(skipTurns){
            skipTurns = false;
            currentState = GameState.enemyTurn;
            Enemy.hasMoved = false;
        }
        else{
            currentState = GameState.playerTurn;
            turnText.text = "Player Turn";
            Player.hasClicked = false;
            StartCoroutine(PlayerTurn());
        }
    }
    public IEnumerator GameWin(){
        var panel = Instantiate(panelOverlay, canvas.transform);
        panel.GetComponent<PanelOverlay>().overlayText.text = "YOU WIN";
        yield return new WaitForSeconds(0.5f);
        Debug.Log("ya");
    }
    public IEnumerator GameLose(){
        var panel = Instantiate(panelOverlay, canvas.transform);
        panel.GetComponent<PanelOverlay>().overlayText.text = "YOU WI-";
        yield return new WaitForSeconds(1f);
        panel.GetComponent<PanelOverlay>().overlayText.text = "TAPI UPIT KAOWKAWOKAOWK";
    }

    void _Check_Cooldown(){
        for(int i = 0; i < SkillContainer.skillObjects.Length; i++){
            Skills skill = SkillContainer.skillObjects[i];
            if (skill != null){
                if (skill.cooldownDiff > 0 && skill.isCooldown){
                    skill.cooldownDiff -= 1;
                }
                else{
                    skill.isCooldown = false;
                } 
            }
        }
    }
}
