using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField]
    [Tooltip("valeur de la rotation générer par la souris")]
    private Vector2 _mouseSensitivity;
    [SerializeField]
    [Tooltip("valeur de la rotation générer par le pad")]
    private Vector2 _padSensitivity;
    [SerializeField]
    [Tooltip("définit la rotation maximum x : vers le bas,et y : vers le haut")]
    private Vector2 _mouseYLimit;
    [SerializeField]
    private Transform _cameraTransform;

    private void Awake()
    {
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        mouseX = _mouseSensitivity.x * Time.deltaTime;
        mouseY = _mouseSensitivity.y * Time.deltaTime;

        float gamePadX = Input.GetAxis("RightHorizontal");
        float gamePadY = Input.GetAxis("RightVertical");
        gamePadX = _padSensitivity.x * Time.deltaTime;
        gamePadY = _padSensitivity.y * Time.deltaTime;

        _horizontal += mouseX + gamePadX;
        _vertical += mouseY + gamePadY;
        _vertical = Mathf.Clamp(_vertical, _mouseYLimit.x, _mouseYLimit.y);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, _horizontal, transform.eulerAngles.z);

        _cameraTransform.eulerAngles = new Vector3(_vertical, _cameraTransform.eulerAngles.y, _cameraTransform.eulerAngles.z);
    }

    private float _horizontal;
    private float _vertical;
}
