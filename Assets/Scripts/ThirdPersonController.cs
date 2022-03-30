using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ThirdPersonController : MonoBehaviour
{
    CharacterController _charaController;

    // Input
    [SerializeField] private InputSystemReader _input;
    [SerializeField] private bool _interact = false;
    [SerializeField] private Vector2 _move = Vector2.zero;

    // Data
    [Range(0, 10)] [SerializeField] private float _speed = 1;

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
            //transform.forward = inputDirection;

            float newAngle = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, newAngle, 0.0f);
        }

        float currentSpeed = _speed * Time.deltaTime;
        Vector3 targetDirection = new Vector3(_move.x, 0, _move.y) * currentSpeed;
        _charaController.Move(targetDirection);

        //Debug.Log(_move + " normalized : " + _move.normalized + " magnitude : " + _move.magnitude + " magnitude normailized : " + _move.normalized.magnitude);
    }

    private void InteractPerformed()
    {
        _interact = true;
    }
    private void InteractCanceled()
    {
        _interact = false;
    }

    private void MovePerformed(Vector2 value)
    {
        _move = value;
    }

    public void OnEnable()
    {
        _input.OnInputInteractEvent += InteractPerformed;
        _input.OnInputInteractEventCanceled += InteractCanceled;
        _input.OnInputMoveEvent += MovePerformed;
    }

    public void OnDisable()
    {
        _input.OnInputInteractEvent -= InteractPerformed;
        _input.OnInputInteractEventCanceled -= InteractCanceled;
        _input.OnInputMoveEvent -= MovePerformed;
    }
}
