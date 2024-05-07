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
        playerData.NowStamina -= playerData.ExpendStamina * Time.deltaTime;

        if (Mathf.Approximately(inputDirection.magnitude, 0))
        {
            StateChenge(PlayerStateType.Idel);
            return;
        }

        if (!isDash || playerData.IsDisappear)
        {
            StateChenge(PlayerStateType.Move);
        }
    }
}
