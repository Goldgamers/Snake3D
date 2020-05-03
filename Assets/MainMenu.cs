// using System.Collections;
// using System.Collections.Generic;

using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TextMesh deathReason;
    public TextMesh gameScore;

    private bool showDeathScreen;
    static InputMaster controls;
    private void Awake()
    {
        controls = new InputMaster();
    }

    
    // This is to load the next Scene
    public void TransitionToMainGame()
    {
        SceneManager.LoadScene(1);
    }


    //This is to Quit the Game
    public void QuitGame()
    {

        Debug.Log("Application has been terminated");
        Application.Quit();
    }

    private static readonly Action<InputAction.CallbackContext> TransMenu = ctx =>
    {
        SceneManager.LoadScene(1);
        controls.UI.StartGame.performed -= TransMenu;
    };

    private void Start()
    {
        controls.UI.StartGame.performed += TransMenu;
       
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
    private void OnEnable()
    {
        controls.UI.Enable();
    }

   
}