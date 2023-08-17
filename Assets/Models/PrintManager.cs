using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;
using Zenject;

public class PrintManager : IInitializable
{
    private readonly ModelManager manager;


    [Inject]
    public PrintManager(ModelManager manager)
    {
        this.manager = manager;
    }

    public void Initialize()
    {
        IObservable<IEnumerable<IModel>> modelCollectionStream = manager.Models
            .ObserveAdd()
            .Select(_ => manager.Models)
            .ToReadOnlyReactiveProperty();

        modelCollectionStream
            .SelectMany(models => models)
            .SelectMany(model => model.Stream)
            .Where(value => value > 20 && value < 40)
            .Where(value => value % 2 == 0)
            .Do(value => Debug.Log($"Filtered value: {value}"))
            .Merge()
            .Subscribe(_ => { });
    }
}
