
using UnityEngine;

[CreateAssetMenu(fileName = "New Bot", menuName = "Bot name", order = 51)]
public class BotConfig : ScriptableObject
{
    public GameObject Body;
    public int Health;
    public int Damage;
}
