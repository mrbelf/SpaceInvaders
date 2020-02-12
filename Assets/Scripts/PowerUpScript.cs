using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float interpolationSpeed;
    public float speed;

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
    private void Update()
    {
        this.color = this.color + interpolationSpeed * Time.deltaTime;
        Color c = new Color(Mathf.Sin(color + redDisplacement), Mathf.Sin(color + greenDisplacement), Mathf.Sin(color + blueDisplacement));
        this.gameObject.GetComponent<Renderer>().material.color = c;
        this.transform.position += Vector3.down * speed * Time.deltaTime;
        if (this.transform.position.y < 1.3f) {
            if (this.transform.position.y < 0f)
            {
                Destroy(this.gameObject);
            }
            else {
                if (Mathf.Abs(GameObject.Find("SceneManager").GetComponent<SceneManagerScript>().getPlayer().transform.position.y-this.transform.position.y)<0.7f) {
                    GameObject.Find("SceneManager").GetComponent<SceneManagerScript>().getPlayer().GetComponent<PlayerPowerUpScript>().PowerUp();
                    Destroy(this.gameObject);
                }
            }
            
        }
    }
}
