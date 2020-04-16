using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Fruit")
        {
            Debug.Log("Fruit Collision!!");
            GameLoop.addScore();
            GameLoop.newFruit();
            GameLoop.addHead();
        }
        else
        {
            Debug.Log("Other Collision!!");


        }


        print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
        print("Their relative velocity is " + collisionInfo.relativeVelocity);
    }
}
