using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbulanceMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Transform _startPoint;
    [SerializeField]
    private Transform _endPoint;

    private void Awake()
    {
        transform.position = _startPoint.position;
    }
    void Start()
    {
        
    }
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        
         if (_isForward)
         {
             _timerMovement += Time.deltaTime;
             if (_timerMovement >= _speed)
             {
                 _isForward = false;
             }
         }
         else
         {
             _timerMovement -= Time.deltaTime;
             if (_timerMovement <= 0f)
             {
                 _isForward = true;
             }
         }
         Vector3 newPosition = Vector3.Lerp(_startPoint.position, _endPoint.position, _timerMovement / _speed);
         transform.position = newPosition;
    }
   
    private float _timerMovement = 0f;
    private bool _isForward = true;
}
