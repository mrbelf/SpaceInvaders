using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confetti : MonoBehaviour
{
    public GameObject confettiUnity;

    void Start()
    {
        for (int i = 0; i < 100; i++) {
            Instantiate(confettiUnity,new Vector3(Random.Range(-5.5f,5.5f),5f,1f),transform.rotation);
        }
    }
}
