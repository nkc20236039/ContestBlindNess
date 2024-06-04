using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
using UnityEditor;
using Parameter;

public class PlayerDebugWindow : DebugWindowVisualizer
{
    [SerializeField]
    private PlayerData playerData;

    protected override void DebugLabels(int id)
    {
        playerData.CurrentStamina = 100;
        playerData.isDebug = true;
        GUILayout.Label($"Playerの速度:{playerData.moveSpeed}");
        GUILayout.Label($"本来なら使用可能か:{playerData.canDash}");
        GUILayout.Label($"スタミナの消費量:{playerData.staminaConsumption}");
    }
}