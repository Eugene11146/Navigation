using UnityEngine;
using Zenject;
public class TransferTargetsForBots : MonoBehaviour
{
    private Spawner _spawner;

    [Inject]
    private void Construct(Spawner spawner)
    {
        _spawner = spawner;
    }
    private void Awake()
    {
        TransferTargets();
    }
    //Передача списка возможных целей каждому Боту
    private void TransferTargets()
    {
        for (int i = 0; i < _spawner.Targets.Count; i++)
        {
            _spawner.Targets[i].GetComponent<BotFindTarget>().AllTargets = _spawner.Targets;
        }
    }
}