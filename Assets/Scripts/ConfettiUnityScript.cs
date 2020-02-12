using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfettiUnityScript : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Renderer>().material.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    private void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * Random.Range(-1f,1f);
    }
}
