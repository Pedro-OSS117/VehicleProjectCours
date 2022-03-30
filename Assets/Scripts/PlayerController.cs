using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Input
    [SerializeField] private InputSystemReader _input;
    [SerializeField] protected bool _interact = false;
    [SerializeField] protected Vector2 _move = Vector2.zero;
    [SerializeField] protected Vector2 _look = Vector2.zero;

    protected virtual void InteractPerformed()
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

    private void LookPerformed(Vector2 value)
    {
        _look = value;
    }

    public void OnEnable()
    {
        _input.OnInputInteractEvent += InteractPerformed;
        _input.OnInputInteractEventCanceled += InteractCanceled;
        _input.OnInputMoveEvent += MovePerformed;
        _input.OnInputLookEvent += LookPerformed;
    }

    public void OnDisable()
    {
        _input.OnInputInteractEvent -= InteractPerformed;
        _input.OnInputInteractEventCanceled -= InteractCanceled;
        _input.OnInputMoveEvent -= MovePerformed;
        _input.OnInputLookEvent -= LookPerformed;
    }
}
