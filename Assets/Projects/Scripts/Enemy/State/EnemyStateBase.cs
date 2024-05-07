using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyStateBase : IState
{
    protected EnemyContext context;
    protected EnemyData enemyData;
    private Action<Enum> changeState;

    public EnemyStateBase(EnemyContext context)
    {
        this.context = context;
        this.enemyData = context.enemyData;
    }

    public Action<Enum> ChangeState { set => changeState = value; }

    protected void StateChange(BlindnessStateType enemyState)
    {
        changeState?.Invoke(enemyState);
    }

    public abstract void OnEnter();
    public abstract void OnExit();
    public abstract void OnFixedUpdate();
    public abstract void OnUpdate();
}
