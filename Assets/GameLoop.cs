﻿// using System;

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// using UnityEngine.UI;
// using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class GameLoop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fruit;
    public GameObject head;
    List<GameObject> snakeParts;
    public TextMesh gamescore;

    private static int scoreCount;

    // Renderer newHeadc;
    public static int lastDeathReason;
    public static bool isDeath;
    int x, y; // for random fruit spawning
    private const float Speed = 0.10f;
    private static int currentDirecton = 2; // clockwise 1 UP 2 RIGHT 3 DOWN 4 LEFT 
    private GameObject newHead;
    InputMaster controls;
    public GameObject pauseMenuUi;
    private bool gameIsPaused;

    private readonly Action<InputAction.CallbackContext> changeDirUp = ctx =>
    {
        if (currentDirecton != 3)
        {
            currentDirecton = 1;
            Debug.Log("UP");
        }
    };

    private readonly Action<InputAction.CallbackContext> changeDirDown = ctx =>
    {
        if (currentDirecton != 1)
        {
            currentDirecton = 3;
            Debug.Log("DOWN");
        }
    };

    private readonly Action<InputAction.CallbackContext> changeDirLeft = ctx =>
    {
        if (currentDirecton != 2)
        {
            currentDirecton = 4;
            Debug.Log("LEFT");
        }
    };

    private readonly Action<InputAction.CallbackContext> changeDirRight = ctx =>
    {
        if (currentDirecton != 4)
        {
            currentDirecton = 2;
            Debug.Log("RIGHT");
        }
    };


    private void Awake()
    {
        controls = new InputMaster();
    }

    public static int GetScore()
    {
        return scoreCount;
    }

    private void Start()
    {
        Time.timeScale = 1f;
        isDeath = false;
        lastDeathReason = 0;
        fruit = GameObject.FindGameObjectWithTag("fruit");
        x = Random.Range(1, 63);
        y = Random.Range(-24, 24);
        var newPos = new Vector3(x, y, 0);
        fruit.transform.position = newPos;

        snakeParts = new List<GameObject> {head};

        var clone1 = Instantiate(head);
        clone1.name = "init_belly";

        var clonePos = head.transform.position;
        clonePos.x--;
        clone1.transform.position = clonePos;
        snakeParts.Add(clone1);

        var clone2 = Instantiate(head);
        clone2.name = "init_tail";

        clonePos.x--;
        clone2.transform.position = clonePos;
        snakeParts.Add(clone2);
        StartCoroutine(Walk());
        scoreCount = 0;
        controls.Gameplay.ChangeDirLeft.started += changeDirLeft;
        controls.Gameplay.ChangeDirRight.started += changeDirRight;
        controls.Gameplay.ChangeDirUp.started += changeDirUp;
        controls.Gameplay.ChangeDirDown.started += changeDirDown;

        controls.UI.PauseMenu.started += ctx =>
        {
            Debug.Log("PAUSE GAME");
            if (gameIsPaused) Resume();
            else Pause();
        };

        
    }

    private void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        controls.Gameplay.ChangeDirLeft.started += changeDirLeft;
        controls.Gameplay.ChangeDirRight.started += changeDirRight;
        controls.Gameplay.ChangeDirUp.started += changeDirUp;
        controls.Gameplay.ChangeDirDown.started += changeDirDown;
    }

    private void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        controls.Gameplay.ChangeDirLeft.started -= changeDirLeft;
        controls.Gameplay.ChangeDirRight.started -= changeDirRight;
        controls.Gameplay.ChangeDirUp.started -= changeDirUp;
        controls.Gameplay.ChangeDirDown.started -= changeDirDown;
    }

    // Update is called once per frame
    private void Update()
    {
        gamescore.text = "Score: " + scoreCount;
    }

    private IEnumerator Walk()
    {
        while (true)
        {
            newHead = Instantiate(snakeParts[0]);
            newHead.name = "clone_body";
            var posChange = GetDirectionV();
            newHead.transform.position = newHead.transform.position + posChange;
            snakeParts.Insert(0, newHead);
            Destroy(snakeParts[snakeParts.Count - 1]);
            snakeParts.Remove(snakeParts[snakeParts.Count - 1]);
            yield return new WaitForSeconds(Speed);
        }

        // ReSharper disable once IteratorNeverReturns
    }

    private Vector3 GetDirectionV()
    {
        var posChange = new Vector3(0, 0, 0);
        switch (currentDirecton)
        {
            case 4:
                posChange.x = -1;
                break;
            case 2:
                posChange.x = 1;
                break;
            case 1:
                posChange.y = 1;
                break;
            case 3:
                posChange.y = -1;
                break;
        }

        return posChange;
    }

    public void AddHead()
    {
        var clone = Instantiate(snakeParts[0]);
        clone.name = "clone_offspring";
        var newPos = GetDirectionV();
        clone.transform.position = clone.transform.position + newPos;
        snakeParts.Insert(0, clone);
        // newHeadc.material.SetColor("_Color", Random.ColorHSV());
    }

    public void AddScore(int scoreAdd)
    {
        scoreCount += scoreAdd;
    }

    public void NewFruit()
    {
        x = Random.Range(1, 63);
        y = Random.Range(-24, 24);
        Debug.Log(x + " / " + y);
        var newPos = new Vector3(x, y, 0);
        fruit.transform.position = newPos;
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
        controls.UI.Enable();
    }
}