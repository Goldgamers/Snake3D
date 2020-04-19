// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private static bool gameIsPaused;
    public GameObject pauseMenuUi;
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused) Resume();
            else Pause();
        }
    }
    private void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    private void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void TransitionToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
