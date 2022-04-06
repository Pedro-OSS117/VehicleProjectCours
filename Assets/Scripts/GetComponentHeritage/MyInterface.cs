using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface MyInterface
{
    public int Health { get; }

    public void ChangeLife(int life);
}
