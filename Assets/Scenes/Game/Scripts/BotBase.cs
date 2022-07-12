using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BotBase : MonoBehaviour
{
    public abstract int Health { get; set; }
    
    public abstract int Damage { get; set; }

}
