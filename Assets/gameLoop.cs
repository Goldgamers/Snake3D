using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameLoop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fruit;
    public GameObject head;
    List<GameObject> snakeParts;
    TextMesh gamescore;
    public static int scoreCount = 0;

    public bool isDeath = false;
    int x, y; // for random fruit spawning
    float speed = 0.10f;
    int currentDirecton = 2; // clockwise 1 UP 2 RIGHT 3 DOWN 4 LEFT 
    void Start()
    {
        fruit = GameObject.FindGameObjectWithTag("fruit");
        x = Random.Range(1, 63);
        y = Random.Range(-24, 24);
        Vector3 newPos = new Vector3(x, y, 0);
        fruit.transform.position = newPos;

        snakeParts = new List<GameObject>();
        snakeParts.Add(head);

        GameObject clone1 = new GameObject();
        clone1.name = "init_belly";
        clone1 = Instantiate(head);
        Vector3 clonePos = head.transform.position;
        clonePos.x--;
        clone1.transform.position = clonePos;
        snakeParts.Add(clone1);

        GameObject clone2 = new GameObject();
        clone2.name = "init_tail";
        clone2 = Instantiate(head);
        clonePos.x--;
        clone2.transform.position = clonePos;
        snakeParts.Add(clone2);
        StartCoroutine(walk());
        scoreCount = 0;
        isDeath = false;

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
            GameObject newHead;
            newHead = Instantiate(snakeParts[0]);
            newHead.name = "clone_body";
            Vector3 posChange = getDirectionV();
            newHead.transform.position = newHead.transform.position + posChange;
            snakeParts.Insert(0, newHead);
            Destroy(snakeParts[snakeParts.Count - 1]);
            snakeParts.Remove(snakeParts[snakeParts.Count - 1]);
            yield return new WaitForSeconds(speed);
        }
    }

    Vector3 getDirectionV()
    {
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
        return posChange;
    }
    void changeDirection()
    {
        GameObject head = GameObject.FindGameObjectWithTag("snakeHead");
        Vector3 posChange = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentDirecton != 2)
        {
            currentDirecton = 4;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentDirecton != 4)
        {
            currentDirecton = 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentDirecton != 3)
        {
            currentDirecton = 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && currentDirecton != 1)
        {
            currentDirecton = 3;
        }
    }
    public void addHead()
    {
        GameObject clone = Instantiate(snakeParts[0]);
        clone.name = "clone_offspring";
        Vector3 newPos = getDirectionV();
        clone.transform.position = clone.transform.position + newPos;
        snakeParts.Insert(0, clone);
    }
    public void addScore(int scoreAdd)
    {
        // scoreCount++;
        scoreCount += scoreAdd;
    }
    public void newFruit()
    {
        x = Random.Range(1, 63);
        y = Random.Range(-24, 24);
        Debug.Log(x + " / " + y);
        Vector3 newPos = new Vector3(x, y, 0);
        fruit.transform.position = newPos;

    }

}
