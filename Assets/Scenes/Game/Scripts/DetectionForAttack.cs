using UnityEngine;
using UnityEngine.Events;

public class DetectionForAttack : MonoBehaviour
{
    private GameObject _target;
    public BotStatus _status;
   
    public delegate int InputData(int Damage);
    public UnityAction<int> Attack;

    private void Start()
    {
        _target = gameObject.GetComponent<BotMovement>().target;
       
        _status = _target.GetComponent<BotStatus>();
        
    }

    public void MeasureDistanceForAttack()
    {
        if (_target != null && Vector3.Distance(gameObject.transform.position, _target.transform.position) < 2f)
        {
            _target.GetComponent<DetectionForAttack>().Attack?.Invoke(_status.Damage);
        }
        
    }

    public void Check()
    {
        if(_status == null )
        {
            Debug.Log("null");
            _target = gameObject.GetComponent<BotMovement>().target;
            _status = _target.GetComponent<BotStatus>();
        }
    }

}
