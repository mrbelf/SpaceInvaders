using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderScript : MonoBehaviour
{
    public GameObject fadingInvader;
    public GameObject camera;

    private void Start()
    {
        this.camera = GameObject.Find("Main Camera");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        this.camera.GetComponent<CameraShake>().shake();
        Instantiate(this.fadingInvader,this.transform.position,this.transform.rotation);
        Destroy(this.gameObject);

    }
}
