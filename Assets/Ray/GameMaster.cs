using System.Collections;
using System.Collections.Generic;
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
    public Player player;
    public Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        currentState = GameState.START;
        StartCoroutine(BattleStart());
    }

    public IEnumerator BattleStart(){
        //battle begin! setup arena, dll.
        totalTurns = 0;
        enemyPace = 0;
        playerPace = 0;
        yield return new WaitForSeconds(2f);
        currentState = GameState.playerTurn;
    }

    public IEnumerator PlayerTurn(){
        Debug.Log("from master, enemy: "+Player.hasClicked);
        playerPace += 1;
        totalTurns += 1;
        foreach(Skills skill in SkillContainer.skillObjects){
            if (skill.cooldownDiff > 0){
                skill.cooldownDiff -= 1;
            }
            else{
                skill.isCooldown = false;
            }
        }
        //add play animation here
        yield return new WaitForSeconds(1f);
        if (player.funnyBar >= 100) {
            currentState = GameState.WIN;
            StartCoroutine(GameWin());
        }
        else if (skipTurns){
            Debug.Log("keskipk");
            skipTurns = false;
            currentState = GameState.playerTurn;
            Player.hasClicked = false;
        }
        else {
            currentState = GameState.enemyTurn;
            Enemy.hasMoved = false;
        }

    }
    public IEnumerator EnemyTurn(){
        Debug.Log("from master, enemy: "+Player.hasClicked);
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
            player._Generate_Card();
        }
        Player.hasClicked = false;
    }
    public IEnumerator GameWin(){
        Debug.Log("YOU WIN");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("ya");
    }
    public IEnumerator GameLose(){
        Debug.Log("YOU WI-");
        yield return new WaitForSeconds(1f);
        Debug.Log("TAPI UPIT KAOWKAWOKAOWK");
    }
}
