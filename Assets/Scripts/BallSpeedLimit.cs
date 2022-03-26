using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeedLimit : MonoBehaviour
{
    private Rigidbody _ballRb;
    private float _ballVel;
    [SerializeField] float _ballSpeedLimit;
    public float MaxSpeed;

    // Start is called before the first frame update
    private void Start()
    {
        _ballRb = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        _ballVel = _ballRb.velocity.magnitude;
        if (_ballVel > _ballSpeedLimit)
        {
            _ballRb.velocity = _ballRb.velocity.normalized * _ballSpeedLimit;
        }
    }
}
