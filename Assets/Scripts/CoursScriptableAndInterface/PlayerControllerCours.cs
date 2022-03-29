using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerControllerCours : MonoBehaviour
{
    public bool interact;
    public Vector2 move;

    private PlayerInputs _playerInputs;

    // Definition Delegate
    public delegate void MyFirstDelegate();
    public delegate int MySecondDelegate(int param1, string param2);

    // Declaration des variables de type delegate
    private MyFirstDelegate OnMyFirstDelegate;
    private MySecondDelegate OnMySecondDelegate;

    // Declaration des variables de type Unity Action
    private UnityAction OnMyFirstUnityAction;
    private UnityAction<int, string> OnMySecondUnityAction;

    Button button;

    public void Start()
    {
        _playerInputs = new PlayerInputs();
        _playerInputs.Enable();
        _playerInputs.Player.Interact.started += OnInteractStarted;
        _playerInputs.Player.Interact.canceled += OnInteractCanceled;
        _playerInputs.Player.Move.performed += OnMovePerformed;
        _playerInputs.Player.Move.canceled += OnMoveCanceled;
#if UNITY_EDITOR
        _playerInputs.DebugPlayer.Enable();
#endif
        // delegate 
        OnMyFirstDelegate += CallMyFunction;
        OnMyFirstDelegate += CallMyFunction2;
        OnMySecondDelegate += CallMyFunction3;
        OnMySecondDelegate += CallMyFunction4;

        // Unity Action (delegate de Unity)
        OnMyFirstUnityAction += CallMyFunction;
        OnMyFirstUnityAction += CallMyFunction2;
        OnMySecondUnityAction += CallMyFunction5;
        OnMySecondUnityAction += CallMyFunction6;

    }

    private void CallMyFunction()
    {
        Debug.Log("CallMyFunction");
    }

    private void CallMyFunction2()
    {
        Debug.Log("CallMyFunction2");
    }

    private int CallMyFunction3(int paramTest1, string paramTest2)
    {
        Debug.Log("CallMyFunction3 : " + paramTest1);
        return paramTest1;
    }

    private int CallMyFunction4(int paramCallMyTest1, string paramCallMyTest2)
    {
        paramCallMyTest1 += 14;
        Debug.Log("CallMyFunction4 : " + paramCallMyTest1);
        return paramCallMyTest1;
    }

    private void CallMyFunction5(int paramTest1, string paramTest2)
    {
        Debug.Log("CallMyFunction5 : " + paramTest1);
    }

    private void CallMyFunction6(int paramCallMyTest1, string paramCallMyTest2)
    {
        paramCallMyTest1 += 14;
        Debug.Log("CallMyFunction6 : " + paramCallMyTest1);
    }

    private void OnInteractStarted(InputAction.CallbackContext context)
    {
        interact = true;

        OnMyFirstDelegate.Invoke();
        int val = OnMySecondDelegate.Invoke(7, "mouai");

        OnMyFirstUnityAction.Invoke();
        OnMySecondUnityAction.Invoke(val, "coucou");
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
