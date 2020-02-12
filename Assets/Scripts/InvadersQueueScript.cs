using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersQueueScript : MonoBehaviour
{
    public float movesPerSecond;
    public float moveSize;
    public float leftScreen;
    public float rightScreen;
    public GameObject SceneManager;

    //true => right
    //false <= left
    private bool direction;

    private bool nextMoveIsDown;
    private float timeSinceLastMov;

    private void Start()
    {
        this.direction = true;
        this.nextMoveIsDown = false;
        this.timeSinceLastMov = 0;
        this.SceneManager = GameObject.Find("SceneManager");
    }

    void Update()
    {
        if (transform.childCount == 0) {
            Destroy(this.gameObject);
        }
        if (transform.position.y < 2f) 
        {
            this.SceneManager.GetComponent<SceneManagerScript>().EndGame();
        }
        this.timeSinceLastMov += Time.deltaTime;
        if (timeSinceLastMov > 1f / movesPerSecond) {
            if (!this.nextMoveIsDown)
            {
                if (this.direction)
                {
                    transform.position += Vector3.right * moveSize;
                    if (this.transform.position.x > this.rightScreen)
                    {
                        this.direction = !this.direction;
                        this.nextMoveIsDown = true;
                    }
                }
                else
                {
                    transform.position += Vector3.left * moveSize;
                    if (this.transform.position.x < this.leftScreen)
                    {
                        this.direction = !this.direction;
                        this.nextMoveIsDown = true;
                    }
                }
            }
            else {
                transform.position += Vector3.down * moveSize;
                this.movesPerSecond *= 1.1f;
                this.nextMoveIsDown = false;
            }
            this.timeSinceLastMov = 0;
        }
    }
}
