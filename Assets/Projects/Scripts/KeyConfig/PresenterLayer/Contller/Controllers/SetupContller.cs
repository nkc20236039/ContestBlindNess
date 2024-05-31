using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupContller : MonoBehaviour
{
    private MainController mainController;

    private void Awake()
    {
        mainController = GetComponentInParent<MainController>();
    }

    private void OnEnable()
    {
        Setup();
    }

    public void Setup()
    {
        var setupComand = new SetupCmmand(new SavePath());
        var inputData = new InputData(setupComand);

        mainController.InputContller(inputData);
    }

    private void OnDisable()
    {
        Disable();
    }

    private void Disable()
    {
        var autoSavePath = new AutoSavePath();
        var savePath = new SavePath();
        var disableCommand = new DisableComand(autoSavePath,savePath);
        mainController.InputContller(new InputData(disableCommand));
    }

}
