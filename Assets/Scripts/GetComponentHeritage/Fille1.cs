using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fille1 : Mother
{
    public override void Method1()
    {
        base.Method1();
        Debug.Log("Fille1");
    }

    public void MethodSpecifique()
    {
        Debug.Log("Fille1 - MethodSpecifique");
    }

    protected void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        Debug.LogWarning("OnTriggerEnter Fille1");
    }
}
