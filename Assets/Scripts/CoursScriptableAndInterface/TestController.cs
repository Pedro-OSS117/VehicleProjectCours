using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestController : MonoBehaviour
{
    [SerializeField] private MyFirstScriptable _data;

    [SerializeField] private int _life;

    public UnityAction myAction;

    public UnityEvent myEvent;

    private void OnEnable()
    {
        Debug.Log("coucou ");
    }

    // Start is called before the first frame update
    void Start()
    {
        _life = _data.startLife;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ApplyAttack(MyFirstScriptable typeEnemy)
    {
        if(typeEnemy == _data.Target)
        {
            // DO Attack
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _data.debugColor;
        Gizmos.DrawWireSphere(transform.position, _data.range);
    }
}
