using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersQueueScript : MonoBehaviour
{
    public float movesPerSecond;
    public float moveSize;
    public float leftScreen;
    public float rightScreen;

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
    }

    void Update()
    {
        if (transform.childCount == 0) {
            Destroy(this.gameObject);
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
