using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject sceneManager;

    private void Start()
    {
        this.sceneManager = GameObject.Find("SceneManager");
    }
    void Update()
    {
        if (this.transform.childCount == 0) {
            this.sceneManager.GetComponent<SceneManagerScript>().Congratulations();
        }   
    }
}
