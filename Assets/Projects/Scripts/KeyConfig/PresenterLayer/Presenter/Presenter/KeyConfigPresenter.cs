using System;
using UnityEngine;

public class KeyConfigPresenter : MonoBehaviour ,IOutPutAction
{
    [SerializeField]
    private GameObject conflictMenu;


    private KeyName_UI[] keyName_UI;

    private ConflictContller conflictContller;
    private Action Refresh_UI;


    private void Start()
    {
        conflictContller = conflictMenu.GetComponent<ConflictContller>();
        keyName_UI = GetComponentsInChildren<KeyName_UI>();
        KeyEnable();
    }

    private void KeyEnable()
    {
        foreach (var key in keyName_UI)
        {
            Refresh_UI += key.RefreshDisplay;
        }
    }

    private void OnDisable()
    {
        KeyDisable();
    }

    private void KeyDisable()
    {
        foreach (var key in keyName_UI)
        {
            Refresh_UI -= key.RefreshDisplay;
        }
    }

    public void Output(OutputData outputData)
    {



        if (outputData.BindingData!=null)
        {
            if (outputData.BindingData.IsConflict)
            {
                conflictMenu.SetActive(true);
                conflictContller.ButtonSetting(outputData.BindingData);
                RefreshDisplay();
            }
            else
            {
                RefreshDisplay();
            }
        }


        if(outputData.DisableData != null)
        {
            KeyEnable();
        }

    }

    public void RefreshDisplay()
    {
        Refresh_UI?.Invoke();
    }

}
