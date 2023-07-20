using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    private float moveSpeed = 1f;
    private bool movingUp = true;


   

    void Update()
    {
        Vector3 currentPosition = transform.position;
        moveSpeed = Random.Range(0.5f, 2f);

        if(currentPosition.y >= 4f|| currentPosition.y <= -4)
        {
            movingUp = !movingUp;
        }

        if(movingUp)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        else 
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
    }

}
