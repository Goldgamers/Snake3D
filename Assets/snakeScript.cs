using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class snakeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cameraWithScript;
    public GameObject snakeHead;
    public GameObject fruit;
    gameLoop GameLoop;
    void Start()
    {
        GameLoop = cameraWithScript.GetComponent<gameLoop>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Death(int Deathreason)
    {
        SceneManager.LoadScene(0);
        GameLoop.isDeath = true;
        int DeathScore = gameLoop.scoreCount;

        switch (Deathreason)
        {
            case 1:
                Debug.Log("died from the Bar Colission");
                break;
            case 2:
                Debug.Log("died from the Clones");
                break;
            default:
                Debug.Log("died from Unknown");
                break;
        }
        WriteScore(gameLoop.scoreCount, Deathreason);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Fruit")
        {
            Debug.Log("Fruit Collision!!");
            GameLoop.addScore(5);
            GameLoop.newFruit();
            GameLoop.addHead();
        }
        else
        {
            if (collisionInfo.collider.name == "Bar_left" || collisionInfo.collider.name == "Bar_right" || collisionInfo.collider.name == "Bar_top" || collisionInfo.collider.name == "Bar_bottom")
            {
                Debug.Log("Bar Collision!!");
                Death(1);

            }
            else
            {
                if (collisionInfo.collider.name == "clone_body")
                {
                    Debug.Log("Clone Colission!!");
                    Death(2);
                }
            }

        }


        print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
        print("Their relative velocity is " + collisionInfo.relativeVelocity);
    }
    void WriteScore(int Score, int Deathreason)
    {

    }

}
