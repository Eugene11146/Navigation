using System.Collections.Generic;
using UnityEngine;

public class BotFindTarget : MonoBehaviour
{
    public List<GameObject> AllTargets;
    [SerializeField] private List<GameObject> _myTargets;
    private BotMovement _movs;
    public bool AreTargetsAvailavle = true;
    private void Start()
    {
        _movs = gameObject.GetComponent<BotMovement>();
        _movs.NewTarget += FindNewTarget;
        SortTargets();
    }
    // Подбор новой цели из оставшихся
    public void FindNewTarget(GameObject Targ)
    {
        AreTargetsAvailavle = true;
        int Number = Random.Range(0, _myTargets.Count);
        for (int i = 0; i < _myTargets.Count; i++)
        {
            if (_myTargets[Number] != null)
            {
                _movs.Target = _myTargets[Number];
                break;
            }
            Number = Random.Range(0, _myTargets.Count);
        }
        FindAvailableTargets();
    }
    // Формирования списка , исключающего себя
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

    //Проверка на наличие доступных целей
    private void FindAvailableTargets()
    {
        int Range = 0;
        for (int l = 0; l < _myTargets.Count; l++)
        {
            if (_myTargets[l] == null)
            {
                Range++;
            }
            if (Range == _myTargets.Count)
            {
                Time.timeScale = 0;
                AreTargetsAvailavle = false;
            }
        }
    }
}