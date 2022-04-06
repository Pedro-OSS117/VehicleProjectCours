using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : PlayerController
{
    [SerializeField] private bool isFrontSteer = true;
    [SerializeField] private WheelCollider[] _wheelFrontColliders;
    [SerializeField] private GameObject[] _wheelMeshFrontColliders;
    [SerializeField] private WheelCollider[] _wheelBackColliders;
    [SerializeField] private GameObject[] _wheelMeshBackColliders;

    [SerializeField] private float _speed = 1;
    [SerializeField] private float _speedSteer = 1;

    [SerializeField] private float _maxSteerAngle = 45;

    [SerializeField] private Transform _originCenterOfMass;
    [SerializeField] private float _downForce = 100;

    public void Start()
    {
        _wheelFrontColliders[0].attachedRigidbody.centerOfMass = _originCenterOfMass.localPosition;

    }

    private void FixedUpdate()
    {
        SteerVehicle(isFrontSteer ? _wheelFrontColliders : _wheelBackColliders);
        ApplyDrive();

        _wheelFrontColliders[0].attachedRigidbody.AddForce(-transform.up * _downForce * _wheelFrontColliders[0].attachedRigidbody.velocity.magnitude);
    }

    private void Update()
    {
        SetViewWheel(_wheelFrontColliders, _wheelMeshFrontColliders);
        SetViewWheel(_wheelBackColliders, _wheelMeshBackColliders);
    }
    private void SteerVehicle(WheelCollider[] _wheelColliders)
    {
        for (int i = 0; i < _wheelColliders.Length; i++)
        {
            if (_move.x != 0)
            {
                _wheelColliders[i].steerAngle += _move.x * _speedSteer;

                if (_wheelColliders[i].steerAngle > _maxSteerAngle)
                {
                    _wheelColliders[i].steerAngle = _maxSteerAngle;
                }
                else if (_wheelColliders[i].steerAngle < -_maxSteerAngle)
                {
                    _wheelColliders[i].steerAngle = -_maxSteerAngle;
                }
            }
            else
            {
                _wheelColliders[i].steerAngle = 0;
            }
        }
    }

    private void ApplyDrive()
    {
        float currentSpeed = _interact ? _speed : 0;
        if (currentSpeed == 0)
        {
            currentSpeed = _interact2 ? -_speed : 0;
        }

        ApplyDriveOnWheel(_wheelFrontColliders, currentSpeed);
        ApplyDriveOnWheel(_wheelBackColliders, currentSpeed);
    }

    private void ApplyDriveOnWheel(WheelCollider[] _wheelColliders, float currentSpeed)
    {
        for (int i = 0; i < _wheelColliders.Length; i++)
        {
            _wheelColliders[i].motorTorque = currentSpeed * Time.deltaTime;
        }
    }

    private void SetViewWheel(WheelCollider[] wheelColliders, GameObject[] wheelMeshes)
    {
        for (int i = 0; i < wheelColliders.Length; i++)
        {
            Quaternion quat;
            Vector3 position;
            wheelColliders[i].GetWorldPose(out position, out quat);
            wheelMeshes[i].transform.position = position;
            wheelMeshes[i].transform.rotation = quat;
        }
    }
}
