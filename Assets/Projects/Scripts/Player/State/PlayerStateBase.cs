using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class PlayerStateBase : IState
{
    protected PlayerContext context;
    protected PlayerData playerData;
    protected PlayerMovement movement;
    protected PlayerDashProcess dashProcess;
    protected PlayerMovementSetting setting;
    private Action<Enum> changeState;
    public Action<Enum> ChangeState { set => changeState = value; }
    protected Vector3 inputDirection;
    protected Rigidbody playerRigidbody ;
    protected bool isDash;

    public PlayerStateBase(PlayerContext context)
    {
        this.context = context;
        this.playerData = context.playerData;
        this.playerRigidbody = context.playerRigidbody;
        this.setting = context.setting;

        movement = new PlayerMovement(context, OnMove);
        dashProcess = new PlayerDashProcess(context, OnDash);
    }

    protected void StateChenge(PlayerStateType state)
    {
        changeState?.Invoke(state);
    }

    public abstract void OnEnter();
    public abstract void OnExit();
    public abstract void OnFixedUpdate();
    public abstract void OnUpdate();

    private void OnMove(InputAction.CallbackContext context)
    {
        inputDirection = new Vector3
            (
                context.ReadValue<Vector2>().x,
                0,
                context.ReadValue<Vector2>().y
            );
    }

    private void OnDash(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isDash = true;
            return;
        }
        isDash = false;
    }
}