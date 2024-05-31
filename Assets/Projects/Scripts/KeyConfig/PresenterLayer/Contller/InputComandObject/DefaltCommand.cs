using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaltCommand
{
    public SavePath SavePath { get; }
    public AutoSavePath AutoSavePath { get; }

    public DefaltCommand(SavePath savePath, AutoSavePath autoSavePath)
    {
        SavePath = savePath;
        AutoSavePath = autoSavePath;
    }
}
