using UnityEngine;

[CreateAssetMenu(fileName = "New Bot", menuName = "Bot name", order = 51)]
public class BotConfig : ScriptableObject
{
    public GameObject Body;
    public int MinHealth;
    public int MaxHealth;
    public int MinDamage;
    public int MaxDamage;
    public int MinSpeed;
    public int MaxSpeed;
}
