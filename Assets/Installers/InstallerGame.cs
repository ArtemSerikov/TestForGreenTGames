using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class InstallerGame : MonoBehaviour
{
    [Inject]
    private ModelManager modelManager;

    [Inject]
    private PrintManager printManager;

    private void Start()
    {
        modelManager.Initialize();      
        printManager.Initialize();
    }

}
