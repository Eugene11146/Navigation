using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class BotMovement : MonoBehaviour
{
    private GameObject target;
    private NavMeshAgent Bot;
    private FindTarget ScripFind;
    private void Assign()
    {
        if (ScripFind != null)
        {
            ScripFind.Finded -= DetectedTarget;
        }
        ScripFind.Finded += DetectedTarget;
    }

    private void Start()
    {
        Bot = gameObject.GetComponent(typeof(NavMeshAgent)) as NavMeshAgent;
        ScripFind = gameObject.GetComponent(typeof(FindTarget)) as FindTarget;
    }

    private void UpdateTarget()
    {
        Bot.destination = target.transform.position;
    }

    private void Update()
    {
        if (GetInput())
        {
            UpdateTarget();
            
        }
    }

    private bool GetInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            return true;
        }
        return false;
    }

    
    private void DetectedTarget(GameObject aim)
    {
        target = aim;
    }
}