using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialInvader : MonoBehaviour
{
    public float interpolationSpeed;

    private float redDisplacement;
    private float greenDisplacement;
    private float blueDisplacement;
    private float color;
    void Start()
    {
        this.redDisplacement = 0f;
        this.greenDisplacement = 2.1f;
        this.blueDisplacement = 4.2f;
        this.color = 0;
    }
    void Update()
    {
        this.color = this.color + interpolationSpeed * Time.deltaTime;
        Color c = new Color(Mathf.Sin(color + redDisplacement), Mathf.Sin(color + greenDisplacement), Mathf.Sin(color + blueDisplacement));
        this.gameObject.GetComponent<Renderer>().material.color = c;
        this.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = c;
        this.gameObject.transform.GetChild(1).GetComponent<Renderer>().material.color = c;
        this.gameObject.transform.GetChild(2).GetComponent<Renderer>().material.color = c;
    }
}
