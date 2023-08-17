using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class MyModel : IModel
{
    private readonly Subject<int> valueSubject = new Subject<int>();

    public IObservable<int> Stream => valueSubject;

    public void EmitValue (int value)
    {
        valueSubject.OnNext (value);
    } 
    public void Dispose ()
    {
        valueSubject.OnCompleted();
        valueSubject.Dispose();
    }
}
