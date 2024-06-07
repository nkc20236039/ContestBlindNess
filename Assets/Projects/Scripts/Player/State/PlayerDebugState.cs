using Player;
using Player.State;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDebugState : PlayerStateBase
{
    public PlayerDebugState(PlayerContext context) : base(context) { }

    private float staminaConsumption = 0;
    private bool canDash => staminaConsumption <= playerData.MaxStamina;

    public override void OnEnter()
    {
        playerData.moveSpeed = playerData.DashSpeed.Front;
    }

    public override void OnExit()
    {
        staminaConsumption = 0;
    }

    public override void OnFixedUpdate()
    {
        //DashState‚Æ“¯‚¶ˆ—
        playerRigidbody.velocity
               = motionCreator.
               Create(inputDirection).
               ObjectView(context.playerCamera).
               PlaneMotion().
               AdvancedForSpeed(
                   playerData.DashSpeed.Front,
                   playerData.DashSpeed.Back,
                   playerData.DashSpeed.Side).
               DeltaTimeForce;
    }

    public override void OnUpdate()
    {
        staminaConsumption += playerData.MaxStamina/playerData.ExpendStamina * Time.deltaTime;
        playerData.staminaConsumption = staminaConsumption;
        playerData.canDash = canDash;

        if (!isDash)
        {
            StateChenge(PlayerStateType.Move);
        }
    }
}
