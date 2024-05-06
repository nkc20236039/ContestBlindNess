using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDashProcess
{
    private PlayerContext context;
    private PlayerData playerData;

    public PlayerDashProcess(PlayerContext context,
        Action<InputAction.CallbackContext> OnDash)
    {
        this.context = context;
        playerData = context.playerData;

        try
        {
            context.inputActions.Player.OnDash.started -= OnDash;
            context.inputActions.Player.OnDash.canceled -= OnDash;
        }
        catch { }

        context.inputActions.Player.OnDash.started += OnDash;
        context.inputActions.Player.OnDash.canceled += OnDash;

    }

    public void DashProcess()
    {
        if (playerData.IsDisappear)
        {
            float coolDownTime = playerData.CooldownStamina * Time.deltaTime;
            playerData.NowStamina = coolDownTime;
        }
        else
        {
            float recoverTime = playerData.RecoverStamina * Time.deltaTime;
            playerData.NowStamina = recoverTime;
        }
    }
}
