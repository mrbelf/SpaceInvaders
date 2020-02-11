using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float shootsPerSecond;
    public GameObject laser;
    private float timeSinceLastShot;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && timeSinceLastShot > 1f/shootsPerSecond)
        {
            Instantiate(laser,this.transform.position,this.transform.rotation);

            this.timeSinceLastShot = 0f;
        }
        this.timeSinceLastShot += Time.deltaTime;
    }
}
