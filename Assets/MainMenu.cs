using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{



// This is to load the next Scene
public void TransitionToMainGame() {


SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

}


//This is to Quit the Game
public void QuitGame() {

Debug.Log("Application has been terminated");
Application.Quit();

}

}