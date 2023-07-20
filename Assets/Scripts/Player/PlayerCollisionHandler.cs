using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Circle))]
public class PlayerCollisionHandler : MonoBehaviour
{
    private Circle _circle;

    private void Start()
    {
        _circle = GetComponent<Circle>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out ScoreObject scoreObject))
        {
            _circle.IncreaseScore();
           // Destroy(collision.gameObject);
            scoreObject.gameObject.SetActive(false);
        }
        else
            _circle.Die();
    }
}
