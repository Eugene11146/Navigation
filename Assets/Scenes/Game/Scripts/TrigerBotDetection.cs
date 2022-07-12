using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrigerBotDetection : MonoBehaviour
{
    public delegate GameObject InputData(GameObject Target);
    public UnityAction<GameObject> Attack;

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
