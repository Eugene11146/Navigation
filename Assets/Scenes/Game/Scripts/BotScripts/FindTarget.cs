using System.Collections.Generic;
using UnityEngine;

public class FindTarget : MonoBehaviour
{
    public List<GameObject> AllTargets;
    [SerializeField] private List<GameObject> _myTargets;
    private BotMovement _movs;
    private void Start()
    {
        _movs = gameObject.GetComponent<BotMovement>();
        _movs.NewTarget += FindNewTarget;
        SortTargets();
    }
    public void FindNewTarget(GameObject Targ)
    {
        int Number = Random.Range(0, _myTargets.Count);
        for (int i = 0; i < _myTargets.Count; i++)
        {
            if (_myTargets[Number] != null)
            {
                _movs.Target = _myTargets[Number];
            }
            Number = Random.Range(0, _myTargets.Count);
        }
    }
    private void SortTargets()
    {
        for (int i = 0; i < AllTargets.Count; i++)
        {
            if (AllTargets[i].GetComponent<BotStatus>().ID != gameObject.GetComponent<BotStatus>().ID)
            {
                _myTargets.Add(AllTargets[i]);
            }
        }
    }
}
