using UnityEngine;
using UniRx;
using Zenject;
using System.Collections.Generic;
using System;

public class ModelManager : IInitializable
{
    private readonly ReactiveCollection<IModel> models = new ReactiveCollection<IModel>();


    public IReadOnlyReactiveCollection<IModel> Models => models;

    public void Initialize()
    {

    }
}

