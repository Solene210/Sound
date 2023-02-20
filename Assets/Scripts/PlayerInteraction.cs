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
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, _maxDistance))
        {
            _target = hitInfo.collider.GetComponent<IUsable>();
            Debug.Log("Hit something");
            //Debug.DrawRay(ray.origin, transform.forward, Color.red);
        }
        else
        {
            _target= null;
            Debug.Log("Did not hit something");
            //Debug.DrawRay(ray.origin, transform.forward, Color.yellow);
        }
    }

    private void UseTarget()
    {
        if(Input.GetButtonDown("Use"))
        {
            _target.Use();
        }
    }

    private void ChangeCrossHairState()
    {
        if (_target != null)
        {
            _knob.color = Color.green;
        }
        else
        {
            _knob.color = Color.white;
        }
    }

    private IUsable _target;
}
