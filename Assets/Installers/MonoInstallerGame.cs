using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MonoInstallerGame : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IModel>().To<MyModel>().AsSingle();

        Container.Bind<ModelManager>().AsSingle();

        Container.Bind<PrintManager>().AsSingle();
    }
}
