using UnityEngine;

public abstract class BotBaseManager : MonoBehaviour
{
    public abstract void MeasureDistanceToTarget();
    public abstract void UpdateUIInfo();
    public abstract void UpdateStatus();
    public abstract void UpdateTarget();
}
