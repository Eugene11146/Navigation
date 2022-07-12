using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotManager : MonoBehaviour
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
        _movement.UpdateTarget();
        _detection.Check();

    }

    private void FixedUpdate()
    {
        _status.Death();
        _status.TakeInf();
        _detection.MeasureDistanceForAttack();
        _uIInfo.UpdateHp();
        _uIInfo.UpdateScore();


    }
}
