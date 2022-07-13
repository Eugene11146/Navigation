using UnityEngine;


public class BotStatus : MonoBehaviour
{
    public BotConfig Config;
    public float Health;
    public int Damage;
    public int Score;
    public int ID;

    private float _damageTime = 0.5f;

    private DetectionForAttack detection;

    private void Start()
    {
        Health = Random.Range(Config.MinHealth, Config.MaxHealth);
        Damage = Random.Range(Config.MinDamage, Config.MaxDamage);
        ID = Random.Range(0, 999);
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

    public void TakeInfoDamage()
    {
        if (detection != null)
        {
            detection.Attack += TakeDamage;
        }
    }

    public void Death()
    {
        if(Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
