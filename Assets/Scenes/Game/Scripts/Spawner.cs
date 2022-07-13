using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> SpawnPoints;
    private int place;
    public List<BotConfig> AllUnits;
    public List<GameObject> Targets;

    private void Awake()
    {
        for (int i = 0; i < AllUnits.Count; i++)
        {
            RandomValue();
            Targets.Add(Instantiate(AllUnits[i].Body, SpawnPoints[place].transform.position, SpawnPoints[place].transform.rotation));
        }
    }

    private void RandomValue()
    {
       place = Random.Range(0,SpawnPoints.Count);
    }
}
