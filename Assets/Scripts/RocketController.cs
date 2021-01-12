using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

    public GameObject _leftThruster;
    public GameObject _rightThruster;

    public float velocity;

    private Rigidbody2D _rbLeft;
    private Rigidbody2D _rbRight;

    void Start()
    {
        _rbLeft = _leftThruster.GetComponent<Rigidbody2D>();
        _rbRight = _rightThruster.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var velocityVector = transform.TransformDirection(Vector2.up) * velocity;

        Debug.DrawRay(_rbLeft.position, velocityVector, Color.red);
        Debug.DrawRay(_rbRight.position, velocityVector, Color.red);

        _rbLeft.velocity = velocityVector;
        _rbRight.velocity = velocityVector;
    }
}
