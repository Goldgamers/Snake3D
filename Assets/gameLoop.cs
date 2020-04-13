using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameLoop : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject fruit;
    TextMesh gamescore;
    int scoreCount = 0;
    int x, y;
    void Start()
    {
        fruit = GameObject.FindGameObjectWithTag("fruit");
        x = Random.Range(1, 63);
        y = Random.Range(-24, 24);
        Vector3 newPos = new Vector3(x, y, 0);
        fruit.transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
        makeMove();
        gamescore = GameObject.FindGameObjectWithTag("gameScore01").GetComponent<TextMesh>();
        gamescore.text = "Score: " + scoreCount;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Fruit")
        {
            Debug.Log("Fruit Collision!!");
            newFruit();
            scoreCount++;
        }
        else
        {
            Debug.Log("Other Collision!!");
            Application.LoadLevel(Application.loadedLevel);
        }


        // print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        // print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
        // print("Their relative velocity is " + collisionInfo.relativeVelocity);
    }

    void makeMove()
    {
        GameObject head = GameObject.FindGameObjectWithTag("snakeHead");
        Vector3 posChange = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            posChange.x = -1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            posChange.x = 1;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            posChange.y = 1;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            posChange.y = -1;
        }
        head.transform.position = head.transform.position + posChange;
    }
    void newFruit()
    {
        x = Random.Range(1, 63);
        y = Random.Range(-24, 24);
        Debug.Log(x + " / " + y);
        Vector3 newPos = new Vector3(x, y, 0);
        fruit.transform.position = newPos;

    }

}
