using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderScript : MonoBehaviour
{
    public GameObject fadingInvader;
    public GameObject cam;


    private void Start()
    {
        Color c = new Color(Random.Range(0f, 1f),Random.Range(0f, 1f),Random.Range(0f, 1f));
        this.gameObject.GetComponent<Renderer>().material.color = c;
        this.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = c;
        this.gameObject.transform.GetChild(1).GetComponent<Renderer>().material.color = c;
        this.gameObject.transform.GetChild(2).GetComponent<Renderer>().material.color = c;
        cam = GameObject.Find("Main Camera");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        cam.GetComponent<CameraShake>().shake();
        Instantiate(this.fadingInvader,this.transform.position,this.transform.rotation);
        Destroy(this.gameObject);

    }
}
