using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderScript : MonoBehaviour
{
    public GameObject fadingInvader;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Instantiate(this.fadingInvader,this.transform.position,this.transform.rotation);
        Destroy(this.gameObject);

    }
}
