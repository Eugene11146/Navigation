using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Zenject;

public class FindTarget : MonoBehaviour
{
    protected GameObject _target;
    private Spawner _spawner;

    public delegate GameObject InputData(GameObject Target);
    public UnityAction<GameObject> Finded;



    protected Spawner spawner;

    [Inject]
    private void Construct(Spawner spawner)
    {
        _spawner = spawner;
    }

    private void Start()
    {
        ChoseTarget();
    }

    private void ChoseTarget()
    {
        _target = _spawner.AllUnits[Random.Range(0, _spawner.AllUnits.Count)];
        Debug.Log(_target.name);
        Finded?.Invoke(_target);
    }
}
