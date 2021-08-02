using Zenject;
using UnityEngine;
using System.Collections;

public class TestInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ISphereController>().To<SphereController>().AsSingle();
        Container.Bind<ISphereModel>().To<SphereModel>().AsSingle();
    }
}