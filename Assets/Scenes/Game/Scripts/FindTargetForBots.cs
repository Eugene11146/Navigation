using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class FindTargetForBots : MonoBehaviour
{
    protected GameObject _target;
    private Spawner _spawner;
   
    
    [Inject]
    private void Construct(Spawner spawner)
    {
        _spawner = spawner;
        Debug.Log("nooooo");
    }

    private void Awake()
    {
        ChoseTarget();
    }

    private void ChoseTarget()
    {
        if (_spawner == null)
        {
            Debug.Log("yes");
        }
       // for (int i = 0; i < _spawner.AllUnits.Count; i++)
        {
           // objects.Add(_spawner.AllUnits[i].Body);
        }
        for (int i = 0; i < _spawner.Targets.Count; i++)
        {
            int Number = Random.Range(0, _spawner.Targets.Count);
            if (i == Number && Number != 0)
            {
                Number--;
            }
            if (i == Number && Number == 0)
            {
                Number++;
            }

            Debug.Log(_spawner.Targets.Count);
            _spawner.Targets[i].GetComponent<BotMovement>().target = _spawner.Targets[Number];

        }
  
    }
}
