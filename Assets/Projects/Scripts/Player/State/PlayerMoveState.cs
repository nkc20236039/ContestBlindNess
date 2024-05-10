using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.State
{
    public class PlayerMoveState : PlayerStateBase
    {
        public PlayerMoveState(PlayerContext context) : base(context) { }

        public override void OnEnter()
        {

        }

        public override void OnExit()
        {

        }

        public override void OnFixedUpdate()
        {
            playerRigidbody.velocity
                = motionCreator.
                Create(inputDirection).
                ObjectView(context.playerHead).
                PlaneMotion().
                AdvancedForSpeed(
                    playerData.DefoltSpeed.Front,
                    playerData.DefoltSpeed.Back,
                    playerData.DefoltSpeed.Side).
                DeltaTimeForce;
        }

        public override void OnUpdate()
        {
            if (playerData.CurrentStamina < playerData.MaxStamina)
            {
                dashProcess.DashProcess();
            }

            //スタミナが切れてなければ
            if (isDash && playerData.IsDisappear)
            {
                StateChenge(PlayerStateType.Dash);
                return;
            }

            if (Mathf.Approximately(inputDirection.magnitude, 0))
            {
                StateChenge(PlayerStateType.Idel);
                return;
            }
        }
    }
}