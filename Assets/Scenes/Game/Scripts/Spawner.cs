using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> SpawnPoints;
    private int place;
    [SerializeField] private List<BotConfig> AllUnits;
    public List<GameObject> Targets;

    public int a = 4;

    private void Awake()
    {
        for (int i = 0; i < AllUnits.Count; i++)
        {
            RandomValue();
            Targets.Add(Instantiate(AllUnits[i].Body, SpawnPoints[place].transform.position, SpawnPoints[place].transform.rotation));
        }

        Debug.Log(AllUnits.Count);
    }

    private void RandomValue()
    {
       place = Random.Range(0,SpawnPoints.Count);
    }

    private void Spawn()
    {
        
    }
}
