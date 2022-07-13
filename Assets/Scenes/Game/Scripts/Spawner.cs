using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> spawnPoints;
    private int _place;
    public List<BotConfig> AllUnits;
    public List<GameObject> Targets;

    private void Awake()
    {
        for (int i = 0; i < AllUnits.Count; i++)
        {
            RandomValue();
            Targets.Add(Instantiate(AllUnits[i].Body, spawnPoints[_place].transform.position, spawnPoints[_place].transform.rotation));
        }
    }
    private void RandomValue()
    {
       _place = Random.Range(0,spawnPoints.Count);
    }
}