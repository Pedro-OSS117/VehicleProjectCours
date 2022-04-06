using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractFamily : MonoBehaviour
{
    Mother[] mothers;

    private void Start()
    {
        mothers = FindObjectsOfType<Mother>();

        for (int i = 0; i < mothers.Length; i++)
        {
            mothers[i].Method1();
            mothers[i].ChangeLife(10);

            // Methode pas brutale
            if (mothers[i] is Fille1 fille1)
            {
                ((Fille1)mothers[i]).MethodSpecifique();
                fille1.MethodSpecifique();
            }

            // Methode brutale
            try
            {
                ((Fille1)mothers[i]).MethodSpecifique();
            }
            catch(Exception e)
            {
                Debug.Log(e);
                // Gestion de l'exception
            }
        }
    }

    public void Update()
    {
        //if(Input.GetKey(KeyCode.A))
        {
            for (int i = 0; i < mothers.Length; i++)
            {
                Interact(mothers[i].gameObject);
            }
        }
    }

    private void Interact(GameObject detected)
    {
        Mother mother = detected.GetComponent<Mother>();
        if(mother != null)
        {
            //mother.Method1();
        }

        // Recuperation de classe implementant une interface via GetComponent
        MyInterface mono = detected.GetComponent<MyInterface>();
        MyInterface[] monos = detected.GetComponents<MyInterface>();
        if (mono is MyInterface healthable)
        {
            healthable.ChangeLife(12);
        }
    }
}
