using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ThirdPersonController : MonoBehaviour
{
    CharacterController _charaController;

    [SerializeField] private InputSystemReader _input;

    void Start()
    {
        _charaController = GetComponent<CharacterController>();
    }

    private void InteractPerformed(bool started)
    {
        if (started)
        {
            Debug.Log("InteractPerformed");
        }
    }

    public void OnEnable()
    {
        _input.OnInteractEvent += InteractPerformed;
    }

    public void OnDisable()
    {
        _input.OnInteractEvent -= InteractPerformed;
    }
}
