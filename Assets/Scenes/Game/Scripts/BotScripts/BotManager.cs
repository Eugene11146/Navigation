using UnityEngine;

public class BotManager : BotBaseManager
{
    private BotStatus _status;
    private BotMovement _movement;
    private DetectionForAttack _detection;
    public UIInfo _uIInfo;

    private void Start()
    {
        _status = gameObject.GetComponent<BotStatus>();
        _movement = gameObject.GetComponent<BotMovement>();
        _detection = gameObject.GetComponent<DetectionForAttack>();
    }
    private void Update()
    {
        UpdateTarget();
    }

    private void FixedUpdate()
    {
        UpdateStatus();
        MeasureDistanceToTarget();
        UpdateUIInfo();
    }
    public override void MeasureDistanceToTarget()
    {
        _detection.MeasureDistanceForAttack();
    }

    public override void UpdateUIInfo()
    {
        _uIInfo.UpdateHp();
        _uIInfo.UpdateScore();
    }

    public override void UpdateStatus()
    {
        _status.Death();
        _status.TakeInfoDamage();
    }

    public override void UpdateTarget()
    {
        _movement.UpdateTarget();
        _detection.CheckTarget();
    }
}