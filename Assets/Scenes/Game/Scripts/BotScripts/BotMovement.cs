using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
//����� ���������� �� ����������� ���� � ����
public class BotMovement : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent _botNavMesh;
   
    public delegate GameObject InputData(GameObject TR);
    public UnityAction<GameObject> NewTarget;

    private void Start()
    {
        _botNavMesh = gameObject.GetComponent<NavMeshAgent>();
        _botNavMesh.speed = gameObject.GetComponent<BotStatus>().Speed;
    }

    //����������� � ���� + �������� �� ������� ���� 
    public void UpdateTarget()
    {
        if (Target != null)
        {
            _botNavMesh.destination = Target.transform.position;
        }
        if(Target == null )
        {
            NewTarget?.Invoke(Target);
        }    
    }
}