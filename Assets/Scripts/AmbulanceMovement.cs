using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbulanceMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _maxDistance;
    [SerializeField]
    private float _minDistance;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void PushForward()
    {
        _rigidBody.velocity = transform.forward * _speed;
    }

    private void UTurn()
    {
        transform.forward = -transform.forward;
        _isFacingNorth = !_isFacingNorth;
        PushForward();
    }

    private bool _isFacingNorth;
    private Rigidbody _rigidBody;
}
