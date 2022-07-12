using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class BotMovement : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent Bot;

    public BotConfig EnBot;
    
    private void Start()
    {
        Bot = gameObject.GetComponent(typeof(NavMeshAgent)) as NavMeshAgent;
    }

    private void UpdateTarget()
    {
        
        Bot.destination = target.transform.position;
        
    }

    private void Update()
    {
        UpdateTarget();

    }

    private void Targeten()
    {
        target = EnBot.Body;
        
    }

}