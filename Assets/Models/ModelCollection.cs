using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public interface IModel
{
    IObservable<int> Stream { get; }
    void EmitValue(int value);
}

public class ModelsCollection : IModel
{
    private readonly Subject<int> valueSubject = new Subject<int>();

    public IObservable<int> Stream => valueSubject;

    public void EmitValue (int value)
    {
        valueSubject.OnNext (value);
    }
}
