using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "New InputSystemReader", menuName = "VehicleProject/InputReader")]
public class InputSystemReader : ScriptableObject, PlayerInputs.IPlayerActions
{
    public UnityAction<bool> OnInteractEvent;

    private PlayerInputs _playerInputs;

    public void OnEnable()
    {
        _playerInputs = new PlayerInputs();
        _playerInputs.Player.SetCallbacks(this);
        _playerInputs.Player.Enable();
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        OnInteractEvent?.Invoke(context.started);
    }

    public void OnInteract2(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
