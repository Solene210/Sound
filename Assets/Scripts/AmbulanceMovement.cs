using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbulanceMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Transform[] _waypoint;
    [SerializeField]
    private float _reachTolerance = 0.1f;

    void Start()
    {
         transform.position = _waypoint[0].position;
        _targetWaypointIndex = 1;
    }
    void Update()
    {
        Vector3 currentWaypointPosition = _waypoint[_targetWaypointIndex].position;
        Vector3 position = Vector3.MoveTowards(transform.position, currentWaypointPosition, _speed * Time.deltaTime);
        transform.position = position;

        if (Vector3.Distance(transform.position, currentWaypointPosition) <= _reachTolerance)
        {
            Movement();
        }
    }

    private void Movement()
    {
        if (_isForward)
        {
            _targetWaypointIndex++;
            if (_targetWaypointIndex >= _waypoint.Length - 1)
            {
                _isForward = false;
            }
        }
        else
        {
            _targetWaypointIndex--;
            if (_targetWaypointIndex <= 0)
            {
                _isForward = true;
            }
        }
    }
    private int _targetWaypointIndex;
    private bool _isForward = true;
}
