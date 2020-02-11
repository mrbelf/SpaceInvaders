using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameAnimation : MonoBehaviour
{
    public float screenTime;
    public GameObject sceneManager;
    public GameObject gameOverSFX;

    private float currentScreenTime;

    private void Start()
    {
        this.sceneManager = GameObject.Find("SceneManager");
        this.currentScreenTime = 0;
        this.gameOverSFX = Instantiate(this.gameOverSFX);
    }
    void Update()
    {
        this.currentScreenTime += Time.deltaTime;
        if (this.currentScreenTime >= this.screenTime) {
            this.sceneManager.GetComponent<SceneManagerScript>().GoToMenu();
            Destroy(this.gameOverSFX);
            Destroy(this.gameObject);
        }
    }
}
