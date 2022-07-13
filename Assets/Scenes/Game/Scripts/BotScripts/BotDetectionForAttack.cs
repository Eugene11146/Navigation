using UnityEngine;
using UnityEngine.Events;

//����� ��� ��������� ��������� ��� ����� ����
public class BotDetectionForAttack : MonoBehaviour
{
    private GameObject _target;
    private BotStatus _status;

    public delegate int InputData(int Damage);
    public UnityAction<int> Attack;

    //��������� ��������� �� ����
    public void MeasureDistanceForAttack()
    {
        if (_target != null && Vector3.Distance(gameObject.transform.position, _target.transform.position) < 2f)
        {
            _target.GetComponent<BotDetectionForAttack>().Attack?.Invoke(_status.Damage);
        }
    }
    //�������� ���� �� �������
    public void CheckTarget()
    {
        if (_target == null && gameObject.GetComponent<BotFindTarget>().AreTargetsAvailavle == true)
        {
            _target = gameObject.GetComponent<BotMovement>().Target;
            _status = _target.GetComponent<BotStatus>();
            _status.IsDead += TargetDead;
        }
    }
    private void TargetDead(int Aim)
    {
        gameObject.GetComponent<BotStatus>().Score++;
    }
}