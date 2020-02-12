using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeTentacules : MonoBehaviour
{
    public float shakeFrequency;
    public float shakeSize;

    private float timeSinceLastShake;
    //right => true
    //left <= false
    public bool direction;

    private void Start()
    {
        this.timeSinceLastShake = 0;
    }
    void Update()
    {
        if (this.timeSinceLastShake > 1f/shakeFrequency) {
            this.timeSinceLastShake = 0f;
            if (direction)
            {
                transform.position += Vector3.right * shakeSize;
            }
            else {
                transform.position += Vector3.left * shakeSize;
            }
            this.direction = !this.direction;
        }
        this.timeSinceLastShake += Time.deltaTime;
    }
}
