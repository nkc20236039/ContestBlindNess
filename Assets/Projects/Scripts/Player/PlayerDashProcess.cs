using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDashProcess
{
    private PlayerContext context;
    private PlayerData playerData;

    public PlayerDashProcess(PlayerContext context,Action<InputAction.CallbackContext> OnDash)
    {
        this.context = context;
        playerData = context.playerData;

        try
        {
            context.inputActions.Player.OnDash.performed -= OnDash;
            context.inputActions.Player.OnDash.canceled -= OnDash;
        }
        catch { }

        context.inputActions.Player.OnDash.performed += OnDash;
        context.inputActions.Player.OnDash.canceled += OnDash;

    }

    public void DashProcess()
    {
        if (playerData.IsDisappear)
        {
            playerData.CurrentStamina += playerData.RecoverStamina * Time.deltaTime;
        }
        else
        {
            playerData.CurrentCoolDown -= playerData.CooldownStamina * Time.deltaTime;
        }

        if (playerData.CurrentCoolDown == 0)
        {
            playerData.CurrentStamina = playerData.MaxStamina;
        }
    }
}
