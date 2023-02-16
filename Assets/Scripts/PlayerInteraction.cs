using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField]
    private float _maxDistance;

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

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        if (true)
        {

        }
        else
        {

        }
    }

    private void UseTarget()
    {

    }

    private void ChangeCrossHairState()
    {

    }

    private IUsable _target;
}
