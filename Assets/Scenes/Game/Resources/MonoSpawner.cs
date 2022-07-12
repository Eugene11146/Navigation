using UnityEngine;
using Zenject;

public class MonoSpawner : MonoInstaller
{
    public Spawner spawner;

    public override void InstallBindings()
    {
        Container.Bind<Spawner>().FromInstance(spawner).AsSingle().NonLazy();
        Container.QueueForInject(spawner);
    }

}