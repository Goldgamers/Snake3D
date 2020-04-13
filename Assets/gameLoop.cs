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
    int x, y; // for random fruit spawning
    float speed = 0.1f;
    int currentDirecton = 2; // clockwise 1 UP 2 RIGHT 3 DOWN 4 LEFT
    void Start()
    {
        StartCoroutine(walk());
        fruit = GameObject.FindGameObjectWithTag("fruit");
        x = Random.Range(1, 63);
        y = Random.Range(-24, 24);
        Vector3 newPos = new Vector3(x, y, 0);
        fruit.transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
        changeDirection();
        gamescore = GameObject.FindGameObjectWithTag("gameScore01").GetComponent<TextMesh>();
        gamescore.text = "Score: " + scoreCount;
    }
    IEnumerator walk()
    {
        while (true)
        {
            GameObject head = GameObject.FindGameObjectWithTag("snakeHead");
            Vector3 posChange = new Vector3(0, 0, 0);
            if (currentDirecton == 4)
            {
                posChange.x = -1;
            }
            if (currentDirecton == 2)
            {
                posChange.x = 1;

            }
            if (currentDirecton == 1)
            {
                posChange.y = 1;

            }
            if (currentDirecton == 3)
            {
                posChange.y = -1;
            }
            head.transform.position = head.transform.position + posChange;
            yield return new WaitForSeconds(speed);
        }
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

    void changeDirection()
    {
        GameObject head = GameObject.FindGameObjectWithTag("snakeHead");
        Vector3 posChange = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentDirecton = 4;
            Debug.Log("Changed Direction to: " + currentDirecton);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentDirecton = 2;
            Debug.Log("Changed Direction to: " + currentDirecton);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentDirecton = 1;
            Debug.Log("Changed Direction to: " + currentDirecton);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentDirecton = 3;
            Debug.Log("Changed Direction to: " + currentDirecton);
        }
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
