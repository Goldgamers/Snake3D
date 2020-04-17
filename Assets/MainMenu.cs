using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // public GameObject cameraWithScript;
    public TextMesh gameScore;
    gameLoop GameLoop;

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




    void Start()
    {
        gameScore.text = "Score: " + gameLoop.scoreCount;
    }

}