using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSpriteController : MonoBehaviour
{
    public GameObject _leftThruster;
    public GameObject _rightThruster;

    public float velocity;

    public Rigidbody2D _rbLeft;
    public Rigidbody2D _rbRight;

    void Start()
    {


    }

    void Update()
    {
        // _rbLeft.AddForce()
        var newVelocity = transform.TransformDirection(Vector2.up) * velocity;

        Debug.DrawRay(_rbLeft.position, newVelocity, Color.red);
        Debug.DrawRay(_rbRight.position, newVelocity, Color.red);

        _rbLeft.velocity = newVelocity;
        _rbRight.velocity = newVelocity;
    }
}
