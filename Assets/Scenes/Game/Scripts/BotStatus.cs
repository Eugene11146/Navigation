using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BotStatus : BotBase
{
    public override int Health 
    { 
        get => Health; 
        set => Random.Range(10, 20); 
    }

    public override int Damage 
    {
        get => Damage;
        set => Random.Range(1 , 3);
    }


    public void TakeDamage()
    {

    }
}
