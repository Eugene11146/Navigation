using UnityEngine;
using UnityEngine.Events;
public class BotStatus : MonoBehaviour
{
    public BotConfig Config;
    public float Health;
    public int Damage;
    public int Score;
    public int ID;
    public int Speed;
    private float _damageTime = 0.5f;
    private BotDetectionForAttack _detection;

    public delegate int InputData(int AimDeath);
    public UnityAction<int> IsDead;

    //Установка характеристик случайным образом, беря статистику с конфига
    private void Awake()
    {
        Health = Random.Range(Config.MinHealth, Config.MaxHealth);
        Damage = Random.Range(Config.MinDamage, Config.MaxDamage);
        Speed = Random.Range(Config.MinSpeed, Config.MaxSpeed);
        ID = Random.Range(0, 999);
        _detection = gameObject.GetComponent<BotDetectionForAttack>();
    }
    private void TakeDamage(int Dmg)
    {
        _damageTime -= Time.deltaTime;
        if(_damageTime <= 0)
        {
            Health = Health - Dmg*0.1f;
            _damageTime = 5f;
        }
    }

    //Получение урона от Атакающего
    public void TakeInfoDamage()
    {
        if (_detection != null)
        {
            _detection.Attack += TakeDamage;
        }
    }
    //Проверка на смерть
    public void Death()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
            IsDead?.Invoke(1);
        }
    }
}