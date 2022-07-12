using UnityEngine;
using UnityEngine.AI;
using Zenject;
using UnityEngine.Events;

public class BotMovement : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent Bot;
    private BotStatus _status;

    public delegate GameObject InputData(GameObject TR);
    public UnityAction<GameObject> NewTarget;

    private void Start()
    {
        Bot = gameObject.GetComponent(typeof(NavMeshAgent)) as NavMeshAgent;
        _status = gameObject.GetComponent<BotStatus>();
    }

    public void UpdateTarget()
    {
        if (target != null)
        {
            Bot.destination = target.transform.position;
        }
        if(target == null )
        {
            _status.Score++;
            NewTarget?.Invoke(target);
        }    
        
    }

}