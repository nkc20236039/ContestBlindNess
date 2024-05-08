using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDashState : PlayerStateBase
{
    public PlayerDashState(PlayerContext context) : base(context){}

    public override void OnEnter()
    {
    }

    public override void OnExit()
    {
    }

    public override void OnFixedUpdate()
    {
        setting.MovementSetting(inputDirection, playerRigidbody.velocity);
        playerRigidbody.velocity = movement.Mvement() * playerData.DashSpeed;
    }

    public override void OnUpdate()
    {
        playerData.CurrentStamina -= playerData.MaxStamina/playerData.ExpendStamina * Time.deltaTime;

        if(playerData.CurrentStamina == 0)
        {
            playerData.CurrentCoolDown = playerData.CooldownStamina;
        }

        if (Mathf.Approximately(inputDirection.magnitude, 0))
        {
            StateChenge(PlayerStateType.Idel);
            return;
        }

        if (!isDash || !playerData.IsDisappear)
        {
            StateChenge(PlayerStateType.Move);
            return;
        }
    }
}
