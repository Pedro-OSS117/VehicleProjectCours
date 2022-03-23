using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{
    [SerializeField] private MyFirstScriptable _data;


    [SerializeField] private int _life;

    // Start is called before the first frame update
    void Start()
    {
        _life = _data.startLife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ApplyAttack(MyFirstScriptable typeEnemy)
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
