using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private void Awake()
    {
        _characterControlller = GetComponent<CharacterController>();
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
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 direction = transform.right * horizontalInput + transform.forward * verticalInput;
        Vector3 move = direction * _speed * Time.deltaTime;

        _characterControlller.Move(move);
    }

    private CharacterController _characterControlller;
}
