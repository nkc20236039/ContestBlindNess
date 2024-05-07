using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EchoProcess
{
    private PlayerData playerData;
    
    public EchoProcess(PlayerContext context)
    {
        this.playerData = context.playerData;

        context.inputActions.Player.OnEcho.started += OnEcho;
        context.inputActions.Player.OnEcho.canceled += OnEcho;
    }

    public void PlayEcho()
    {
        if (!playerData.IsPlayEcho)
            return;

        //ÉGÉRÅ[ÇÃèàóù

        playerData.CurrentEchoCoolTime = 0;
    }

    public void EchoCoolTime()
    {
        if (playerData.IsPlayEcho)
            return;

        playerData.CurrentEchoCoolTime += playerData.EchoCoolTime * Time.deltaTime;
    }

    public void OnEcho(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            PlayEcho();
        }
    }
}
