using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketController : MonoBehaviour
{

    public GameObject _leftThruster;
    public GameObject _rightThruster;

    public float speed;

    private Rigidbody2D _rbLeft;
    private Rigidbody2D _rbRight;

    private Vector2 _leftDirection;
    private Vector2 _rightDirection;

    private void Start()
    {
        _rbLeft = _leftThruster.GetComponent<Rigidbody2D>();
        _rbRight = _rightThruster.GetComponent<Rigidbody2D>();

        _leftDirection = Vector2.down;
        _rightDirection = Vector2.down;
    }

    private void FixedUpdate()
    {

        // var leftCurrent = (Vector2) _leftThruster.transform.TransformDirection(Vector2.down);
        // var targetMovement = _leftDirection - leftCurrent;

        #if UNITY_EDITOR
        Debug.DrawRay(_rbLeft.position, _rbLeft.transform.TransformDirection(_leftDirection), Color.red);
        Debug.DrawRay(_rbRight.position, _rbRight.transform.TransformDirection(_rightDirection), Color.red);
        #endif

        _rbLeft.AddForce(_rbLeft.transform.TransformDirection(_leftDirection * -1) * speed);
        _rbRight.AddForce(_rbRight.transform.TransformDirection(_rightDirection * -1) * speed);

        // _rbLeft.velocity = _rbLeft.transform.TransformDirection(_leftDirection * -1) * speed;
        // _rbRight.velocity = _rbRight.transform.TransformDirection(_rightDirection * -1) * speed;
    }

    private void OnLeftThruster(InputValue input)
    {
        _leftDirection = input.Get<Vector2>().normalized;
        if(_leftDirection == Vector2.zero) {
            _leftDirection = Vector2.down;
        }
    }

    private void OnRightThruster(InputValue input)
    {
        _rightDirection = input.Get<Vector2>().normalized;
        if(_rightDirection == Vector2.zero) {
            _rightDirection = Vector2.down;
        }

    }
}
