using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BotStatus : BotBase
{
    public BotConfig Config;
    public float Health;
    public int Damage;
    public int Score;

    private float _damageTime = 0.5f;

    private DetectionForAttack detection;

    private void Start()
    {
        Health = Random.Range(Config.MinHealth, Config.MaxHealth);
        Damage = Random.Range(Config.MinDamage, Config.MaxDamage);

        detection = gameObject.GetComponent<DetectionForAttack>();

    }

    public void TakeDamage(int Dmg)
    {
        _damageTime -= Time.deltaTime;
        if(_damageTime <= 0)
        {
            Health = Health - Dmg*0.1f;
            _damageTime = 5f;
        }

    }

    public void TakeInf()
    {
        if(detection != null)
        detection.Attack += TakeDamage;
    }

    public void Death()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
