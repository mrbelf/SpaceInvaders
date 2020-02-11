using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    public float LeftScreen;
    public float RightScreen;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)&&transform.position.x>LeftScreen)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow)&&transform.position.x<RightScreen)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
