using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{

    public GameObject canvas;
    public GameObject player;
    public GameObject enemys;
    public GameObject gameOverScreen;
    public GameObject congratulationsScreen;

    private GameObject currentPlayer;
    private GameObject currentEnemys;

    private bool gameStarted;

    private void Start()
    {
        this.gameStarted = false;
    }
    public void StartGame()
    {
        this.gameStarted = true;
        this.canvas.SetActive(false);
        this.currentPlayer = Instantiate(this.player, Vector3.up*0.5f, Quaternion.identity);
        this.currentEnemys = Instantiate(this.enemys, Vector3.up*3f, Quaternion.identity);
        this.currentEnemys.transform.GetChild(0).transform.GetChild(Random.Range(0, 5)).GetComponent<InvaderScript>().setSpecial();
    }

    public void EndGame()
    {
        Destroy(this.currentPlayer);
        Destroy(this.currentEnemys);
        Instantiate(gameOverScreen);
    }
    public void Congratulations() {
        Destroy(this.currentPlayer);
        Destroy(this.currentEnemys);
        Instantiate(congratulationsScreen);
    }

    public void GoToMenu() {
        this.gameStarted = false;
        this.canvas.SetActive(true);
    }

    public GameObject getPlayer() {
        return this.currentPlayer;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (!this.gameStarted) {
            if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.UpArrow)) {
                this.StartGame();
            }
        }
    }

}
