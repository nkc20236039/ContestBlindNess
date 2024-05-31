using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableComand
{
    public AutoSavePath AutoSavePath { get; }
    public SavePath SavePath { get; }

    public DisableComand(AutoSavePath autoSavePath, SavePath savePath)
    {
        this.AutoSavePath = autoSavePath;
        SavePath = savePath;
    }

}
