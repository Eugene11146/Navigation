using UnityEngine;
//Класс "Фасад" по управлению всеми под системами бота
public class BotManager : BotBaseManager
{
    private BotStatus _status;
    private BotMovement _movement;
    private BotDetectionForAttack _detection;
    public UIInfo _uIInfo;

    private void Start()
    {
        _status = gameObject.GetComponent<BotStatus>();
        _movement = gameObject.GetComponent<BotMovement>();
        _detection = gameObject.GetComponent<BotDetectionForAttack>();
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
    //Измеряет длину до цели
    public override void MeasureDistanceToTarget()
    {
        _detection.MeasureDistanceForAttack();
    }
    //Обновление характеристик в UI
    public override void UpdateUIInfo()
    {
        _uIInfo.UpdateHp();
        _uIInfo.UpdateScore();
    }
    //Обновление информации по получаемому урону и смерти
    public override void UpdateStatus()
    {
        _status.Death();
        _status.TakeInfoDamage();
    }
    //Проверка на наличие цели и ее поиск
    public override void UpdateTarget()
    {
        _movement.UpdateTarget();
        _detection.CheckTarget();
    }
}