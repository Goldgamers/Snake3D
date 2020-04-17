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
    public GameObject GameBars;
    gameLoop GameLoop;
    void Start()
    {
        GameLoop = cameraWithScript.GetComponent<gameLoop>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Death()
    {
        SceneManager.LoadScene(0);
        GameLoop.isDeath = true;
        int DeathScore = gameLoop.scoreCount;
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
                Death();

            }
            else
            {
                if (collisionInfo.collider.name == "clone_body")
                {
                    Debug.Log("Clone Colission!!");
                    Death();
                }
            }

        }


        print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
        print("Their relative velocity is " + collisionInfo.relativeVelocity);
    }


}
