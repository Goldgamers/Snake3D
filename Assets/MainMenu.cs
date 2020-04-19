// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TextMesh deathReason;
    public TextMesh gameScore;

    private bool showDeathScreen;

    
    // This is to load the next Scene
    public void TransitionToMainGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    //This is to Quit the Game
    public void QuitGame()
    {

        Debug.Log("Application has been terminated");
        Application.Quit();
    }


    private void Start()
    {
        var lastDeathReason = GameLoop.lastDeathReason;
        try
        {
            showDeathScreen = GameLoop.isDeath;
            GameLoop.GetScore();
            gameScore.text = "Score: " + GameLoop.GetScore();
        }
#pragma warning disable 168
        catch (UnityException e){}
#pragma warning restore 168
        if (!showDeathScreen)
        {
            deathReason.text = "Get going and score some points!";
        }
        else
        {
            Debug.Log(lastDeathReason);
            switch (lastDeathReason)
            {
                case 1:
                    deathReason.text = "Smashed into a bar";
                    break;
                case 2:
                    deathReason.text = "Bit your own tail";
                    break;
            }
        }


    }
}