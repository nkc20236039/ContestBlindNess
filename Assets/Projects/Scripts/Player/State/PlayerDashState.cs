using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.State
{
    public class PlayerDashState : PlayerStateBase
    {
        public PlayerDashState(PlayerContext context) : base(context) { }

        public override void OnEnter()
        {
#if DEBUG
            playerData.moveSpeed = playerData.DashSpeed.Front;
#endif
        }

        public override void OnExit()
        {
        }

        public override void OnFixedUpdate()
        {
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
            playerData.CurrentStamina -= playerData.MaxStamina / playerData.ExpendStamina * Time.deltaTime;

            if (playerData.CurrentStamina == 0)
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
}