using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

    public GameObject _leftThruster;
    public GameObject _rightThruster;

    public float velocity;

    private Rigidbody _rbLeft;
    private Rigidbody _rbRight;

    void Start()
    {
        _rbLeft = _leftThruster.GetComponent<Rigidbody>();
        _rbRight = _leftThruster.GetComponent<Rigidbody>();

    }

    void Update()
    {
        // _rbLeft.AddForce()
        _rbLeft.velocity = new Vector3(0, velocity * Time.deltaTime, 0);
        _rbRight.velocity = new Vector3(0, velocity * Time.deltaTime, 0);
    }
}
