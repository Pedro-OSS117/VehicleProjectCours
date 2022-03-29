using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "TestFirstScriptable", menuName = "TestFirst")]
public class MyFirstScriptable : ScriptableObject
{
    /// <summary>
    /// Bonjour
    /// </summary>
    public UnityAction evnetRaise;

    public string nameEntity;

    public int startLife = 50;

    public float range = 1;

    public int damage = 1;

    public Color debugColor;

    public Sprite icon;

    [SerializeField] private MyFirstScriptable _target;
    public MyFirstScriptable Target { get { return _target; } }

    /**
     * 
     * 
     **/
    [SerializeField] private List<MyFirstScriptable> _targets;

    /// <summary>
    /// Can be called to apply the effect of the scriptable
    /// Need a controller to
    /// </summary>
    /// <param name="controller">c'est bien</param>
    public void ApplyEffect(PlayerControllerCours controller)
    {
        controller.transform.SetAsFirstSibling();
    }

    private void OnEnable()
    {

    }
}
