using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestFirstScriptable", menuName = "TestFirst")]
public class MyFirstScriptable : ScriptableObject
{
    public string nameEntity;

    public int startLife = 50;

    public float range = 1;

    public int damage = 1;

    public Color debugColor;

    public Sprite icon;

    [SerializeField] private MyFirstScriptable _target;
    public MyFirstScriptable Target { get { return _target; } }

    [SerializeField] private List<MyFirstScriptable> _targets;

    public void ApplyEffect(PlayerController controller)
    {

    }
}
