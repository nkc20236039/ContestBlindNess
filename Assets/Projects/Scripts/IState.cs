using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState 
{
    public Action<Enum> ChangeState { set; }

    public void OnEnter();
    public void OnUpdate();
    public void OnFixedUpdate();
    public void OnExit();
}
