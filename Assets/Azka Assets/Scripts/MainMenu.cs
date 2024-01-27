using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void playButtonClick()
    {
        SceneManager.LoadScene("scene_turn");
    }
    // Start is called before the first frame update
    public void optionsButtonClick()
    {   
        SceneManager.LoadScene("Options");
    }

    // Update is called once per frame
    public void exitButtonClick()
    {
        Debug.Log("Exit button clicked"); // Optional: Log a message for debugging
        Application.Quit();
    }
}
