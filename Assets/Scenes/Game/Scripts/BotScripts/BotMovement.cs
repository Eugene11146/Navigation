using UnityEngine;
using UnityEngine.AI;
using Zenject;
using UnityEngine.Events;

public class BotMovement : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent _botNavMesh;
    private BotStatus _status;

    public delegate GameObject InputData(GameObject TR);
    public UnityAction<GameObject> NewTarget;

    private void Start()
    {
        _botNavMesh = gameObject.GetComponent(typeof(NavMeshAgent)) as NavMeshAgent;
        _status = gameObject.GetComponent<BotStatus>();
    }

    public void UpdateTarget()
    {
        if (Target != null)
        {
            _botNavMesh.destination = Target.transform.position;
        }
        if(Target == null )
        {
            _status.Score++;
            NewTarget?.Invoke(Target);
        }    
        
    }

}