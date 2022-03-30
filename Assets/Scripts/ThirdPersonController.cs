using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ThirdPersonController : PlayerController
{
    CharacterController _charaController;

    // Data
    [Range(0, 10)] [SerializeField] private float _speed = 1;
    private float _targetRotation = 0.0f;

    // Camera
    [SerializeField] private GameObject _mainCamera;

    [Header("Cinemachine")]
    [Tooltip("The follow target set in the Cinemachine Virtual Camera that the camera will follow")]
    [SerializeField] private GameObject _cinemachineCameraTarget;
    [SerializeField] private float _speedCamera = 1;

    [Tooltip("How far in degrees can you move the camera up")]
    [SerializeField] private float _topClamp = 70.0f;
    [Tooltip("How far in degrees can you move the camera down")]
    [SerializeField] private float _bottomClamp = -30.0f;
    [Tooltip("Additional degress to override the camera. Useful for fine tuning camera position when locked")]
    [SerializeField] private float _cameraAngleOverride = 0.0f;
    private const float _threshold = 0.01f;

    // cinemachine
    private float _cinemachineTargetYaw;
    private float _cinemachineTargetPitch;


    [SerializeField] private GameObject _interactOrigin;

    void Start()
    {
        _charaController = GetComponent<CharacterController>();
    }

    public void Update()
    {
        Move();
    }
    
    private void Move()
    {
        if (_move != Vector2.zero)
        {
            Vector3 inputDirection = new Vector3(_move.x, 0, _move.y).normalized;
            _targetRotation = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg + _mainCamera.transform.eulerAngles.y; ;
            transform.rotation = Quaternion.Euler(0.0f, _targetRotation, 0.0f);

            Vector3 targetDirection = Quaternion.Euler(0.0f, _targetRotation, 0.0f) * Vector3.forward;
            _charaController.Move(targetDirection.normalized * (_speed * Time.deltaTime));
        }
    }

    private void LateUpdate()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        // if there is an input and camera position is not fixed
        if (_look.sqrMagnitude >= _threshold)
        {
            _cinemachineTargetYaw += _look.x * Time.deltaTime * _speedCamera;
            _cinemachineTargetPitch += _look.y * Time.deltaTime * _speedCamera;
        }

        // clamp our rotations so our values are limited 360 degrees
        _cinemachineTargetYaw = ClampAngle(_cinemachineTargetYaw, float.MinValue, float.MaxValue);
        _cinemachineTargetPitch = ClampAngle(_cinemachineTargetPitch, _bottomClamp, _topClamp);

        // Cinemachine will follow this target
        _cinemachineCameraTarget.transform.rotation = Quaternion.Euler(_cinemachineTargetPitch + _cameraAngleOverride, _cinemachineTargetYaw, 0.0f);
    }

    private static float ClampAngle(float lfAngle, float lfMin, float lfMax)
    {
        if (lfAngle < -360f) lfAngle += 360f;
        if (lfAngle > 360f) lfAngle -= 360f;
        return Mathf.Clamp(lfAngle, lfMin, lfMax);
    }

    protected override void InteractPerformed()
    {
        Ray ray = new Ray(_interactOrigin.transform.position, _interactOrigin.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, 1))
        {
            Debug.Log(hit.collider.gameObject.name, hit.collider.gameObject);
        }
    }
}
