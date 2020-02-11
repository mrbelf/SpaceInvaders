using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeSize;
    public float shakeFrequency;


    private Vector3 origin;
    public bool shaking;

    private float timeSinceLastShake;
    private float shakingTime;
    private int shakeState;
    private void Start()
    {
        this.shakeState = 0;
        this.shakingTime = 0f;
        this.shaking = false;
        this.origin = new Vector3(transform.position.x,transform.position.y,transform.position.z);
    }
    public void shake() {
        this.shakingTime = 0f;
        this.shaking = true;
    }

    private void Update()
    {
        if (this.shaking && timeSinceLastShake > 1f/shakeFrequency)
        {
            this.timeSinceLastShake = 0f;
            if (this.shakeState == 0)
            {
                transform.position += Vector3.up * shakeSize;
            }
            else if (this.shakeState == 1)
            {
                transform.position += Vector3.left * shakeSize;
            }
            else if (this.shakeState == 2)
            {
                transform.position += Vector3.right * shakeSize;
            }
            else if (this.shakeState == 3)
            {
                transform.position += Vector3.down * shakeSize;
            }
            else if (this.shakeState == 4)
            {
                transform.position += Vector3.forward * shakeSize;
            }
            else if (this.shakeState == 5)
            {
                transform.position += Vector3.back * shakeSize;
                if (this.shakingTime >= 0.5f) {
                    this.shaking = false;
                }
            }
            this.shakeState = (this.shakeState + 1) % 6;
            this.shakingTime += Time.deltaTime;
        }
        this.timeSinceLastShake += Time.deltaTime;
    }
}
