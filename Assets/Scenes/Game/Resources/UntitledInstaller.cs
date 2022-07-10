using UnityEngine;
using Zenject;

public class UntitledInstaller : MonoInstaller
{
    public Spawner spawner;

    public override void InstallBindings()
    {
        Container.Bind<Spawner>().FromInstance(spawner).AsSingle();
    }

}