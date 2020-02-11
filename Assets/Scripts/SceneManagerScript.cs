using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{

    public GameObject canvas;
    public GameObject player;
    public GameObject enemys;
    public GameObject gameOverScreen;

    private GameObject currentPlayer;
    private GameObject currentEnemys;

    public void StartGame()
    {
        this.canvas.SetActive(false);
        this.currentPlayer = Instantiate(this.player, Vector3.up*0.5f, Quaternion.identity);
        this.currentEnemys = Instantiate(this.enemys, Vector3.up*3f, Quaternion.identity);
    }

    public void EndGame()
    {
        Destroy(this.currentPlayer);
        Destroy(this.currentEnemys);
        Instantiate(gameOverScreen);
    }

    public void GoToMenu() {
        this.canvas.SetActive(true);
    }
}
