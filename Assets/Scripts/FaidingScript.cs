using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaidingScript : MonoBehaviour
{
    public float animationTime;
    public float speed;
    private float currentTime;
    void Start() {
        this.currentTime += Time.deltaTime;
    }
    
    void Update()
    {
        this.currentTime += Time.deltaTime;
        if (this.currentTime>=this.animationTime) {
            Destroy(this.gameObject);
        }
        transform.position += ((Vector3.down * speed * Time.deltaTime *0.5f)+(Vector3.left *speed*Time.deltaTime *Random.Range(-2.0f,2.0f)));
        transform.localScale = transform.localScale * 0.99f;
    }
}
