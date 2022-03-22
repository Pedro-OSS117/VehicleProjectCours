using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public bool interact;
    public Vector2 move;

    private PlayerInputs _playerInputs;

    public void Start()
    {
        _playerInputs = new PlayerInputs();

        _playerInputs.Player.Interact.started += OnInteractStarted;
        _playerInputs.Player.Interact.canceled += OnInteractCanceled;
        _playerInputs.Player.Move.performed += OnMovePerformed;
        _playerInputs.Player.Move.canceled += OnMoveCanceled;
#if UNITY_EDITOR
        _playerInputs.DebugPlayer.Enable();
#endif
    }

    private void OnInteractStarted(InputAction.CallbackContext context)
    {
        interact = true;
    }

    private void OnInteractCanceled(InputAction.CallbackContext context)
    {
        interact = false;
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
        move = Vector2.zero;
    }
}
