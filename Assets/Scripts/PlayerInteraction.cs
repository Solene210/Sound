using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField]
    private float _maxDistance;
    [SerializeField]
    private Image _knob;

    void Start()
    {
        
    }

    void Update()
    {
        FindTarget();
        UseTarget();
        ChangeCrossHairState();
    }

    private void FindTarget()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray.origin, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, _maxDistance))
        {
            Debug.Log("Hit something");
            Debug.DrawRay(ray.origin, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.red);
        }
        else
        {
            Debug.Log("Did not hit something");
            Debug.DrawRay(ray.origin, transform.TransformDirection(Vector3.forward) * _maxDistance, Color.yellow);
        }
    }

    private void UseTarget()
    {

    }

    private void ChangeCrossHairState()
    {
        if (true)
        {
            _knob.color = Color.green;
        }
    }

    private IUsable _target;
}
