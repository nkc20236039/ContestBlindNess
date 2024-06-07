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
        GUILayout.Label($"Player�̑��x:{playerData.moveSpeed}");
        GUILayout.Label($"�{���Ȃ�g�p�\��:{playerData.canDash}");
        GUILayout.Label($"�X�^�~�i�̏����:{playerData.staminaConsumption}");
    }
}