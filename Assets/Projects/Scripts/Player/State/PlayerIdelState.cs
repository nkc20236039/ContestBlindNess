using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdelState : PlayerStateBase
{
    public PlayerIdelState(PlayerContext context) : base(context){}

    public override void OnEnter()
    {
        playerRigidbody.velocity = Vector3.zero;
    }

    public override void OnExit()
    {

    }

    public override void OnFixedUpdate()
    {

    }

    public override void OnUpdate()
    {
        if (playerData.CurrentStamina < playerData.MaxStamina)
        {
            dashProcess.DashProcess();
        }

        if (!Mathf.Approximately(inputDirection.magnitude, 0))
        {
            StateChenge(PlayerStateType.Move);
        }
    }
}
