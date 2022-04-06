using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour, MyInterface
{
    public int Health => throw new System.NotImplementedException();

    public virtual void ChangeLife(int life)
    {

    }

    public virtual void Method1()
    {
        Debug.Log("Mother");
    }

    protected void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning("OnTriggerEnter Mother");
    }
}
