using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Unit;
    public int Amount;
    [SerializeField] private List<GameObject> SpawnPoints;
    private int place;

    public  List<GameObject> AllUnits;

    private void Awake()
    {
        for (int i = 0; i < Amount; i++)
        {
            RandomValue();
            Spawn();
        }
    }

    private void RandomValue()
    {
       place = Random.Range(0,SpawnPoints.Count);
    }

    private void Spawn()
    {
        AllUnits.Add(Instantiate(Unit, SpawnPoints[place].transform));
        Debug.Log("yes");
    }
}
