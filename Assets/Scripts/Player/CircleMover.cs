using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CircleMover : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float _speed;
    [SerializeField] private float _tapForce = 10;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
            
        _rigidbody = GetComponent<Rigidbody2D>();
        ResetCircle();
    }

    private void FixedUpdate()
    {
        if( Input.GetKey(KeyCode.Space)||Input.GetMouseButton(0))
        {
            _rigidbody.velocity = new Vector2(_speed, 0);
            _rigidbody.AddForce(Vector2.up * _tapForce, ForceMode2D.Force);
        }
    }

    public void ResetCircle()
    {
        transform.position = _startPosition;
        _rigidbody.velocity = Vector2.zero;
    }
}
