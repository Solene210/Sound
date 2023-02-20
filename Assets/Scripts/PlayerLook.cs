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

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Start()
    {
        
    }

    void Update()
    {
        //Rotation Camera
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity.x * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity.y * Time.deltaTime;
        
        float gamePadX = Input.GetAxis("RightHorizontal") * _padSensitivity.x * Time.deltaTime;
        float gamePadY = Input.GetAxis("RightVertical") * _padSensitivity.y * Time.deltaTime;

        _horizontal += mouseX + gamePadX;
        _vertical += mouseY + gamePadY;
        _vertical = Mathf.Clamp(_vertical, _mouseYLimit.x, _mouseYLimit.y);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, _horizontal, transform.eulerAngles.z);
   
        Camera.main.transform.eulerAngles = new Vector3(_vertical, Camera.main.transform.eulerAngles.y, Camera.main.transform.eulerAngles.z);
    }
    private float _horizontal;
    private float _vertical;
}
