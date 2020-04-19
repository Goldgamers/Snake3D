// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cameraWithScript;
    private GameLoop gameLoop;
    
    void Start()
    {
        gameLoop = cameraWithScript.GetComponent<GameLoop>();

    }
    private static void Death(int deathreason)
    {
        SceneManager.LoadScene(0);
        GameLoop.isDeath = true;
        // int DeathScore = gameLoop.scoreCount;

        switch (deathreason)
        {
            case 1:
                Debug.Log("died from the Bar Colission");
                GameLoop.lastDeathReason = 1;
                break;
            case 2:
                Debug.Log("died from the Clones");
                GameLoop.lastDeathReason = 2;
                break;
            default:
                Debug.Log("died from Unknown");
                break;
        }
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        switch (collisionInfo.collider.name)
        {
            case "Fruit":
                Debug.Log("Fruit Collision!!");
                gameLoop.AddScore(5);
                gameLoop.NewFruit();
                gameLoop.AddHead();
                break;
            case "Bar_left":
            case "Bar_right":
            case "Bar_top":
            case "Bar_bottom":
                Debug.Log("Bar Collision!!");
                Death(1);
                break;
            case "clone_body":
                Debug.Log("Clone Colission!!");
                Death(2);
                break;
        }


        print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
        print("Their relative velocity is " + collisionInfo.relativeVelocity);
    }
   
}
