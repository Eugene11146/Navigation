using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTarget : MonoBehaviour
{
    public List<GameObject> Targets;
    [SerializeField]private List<GameObject> myTargets;
    private BotMovement _movs;
    private void Start()
    {
        _movs = gameObject.GetComponent<BotMovement>();
        _movs.NewTarget += FindNewTarget;
        
        for (int i = 0; i < Targets.Count; i++)
        {
            if (Targets[i].GetComponent<BotStatus>().Health != gameObject.GetComponent<BotStatus>().Health)
            {
                myTargets.Add(Targets[i]);
            }
        }
    }
    public void FindNewTarget(GameObject Targ)
    {
        int Number = Random.Range(0, myTargets.Count);
        for (int i = 0; i < myTargets.Count; i++)
        {
            if (myTargets[Number] != null)
            {
                _movs.target = myTargets[Number];
            }
            Number = Random.Range(0, myTargets.Count);
        }
       
    }
}
