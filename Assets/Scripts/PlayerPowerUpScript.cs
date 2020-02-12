using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUpScript : MonoBehaviour
{
    public GameObject powerUpSFX;
    public void PowerUp() {
        this.gameObject.transform.GetChild(0).GetComponent<Shoot>().shootsPerSecond *=1.5f;
        Instantiate(powerUpSFX,this.transform);
    }
}
