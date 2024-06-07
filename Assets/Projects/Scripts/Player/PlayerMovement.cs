using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using PlayerMotion;
using Parameter;

public class PlayerMovement
{
    private PlayerContext context;
    private PlayerData playerData;
    private PlayerMovementSetting setting;

    public PlayerMovement(PlayerContext context,Action<InputAction.CallbackContext> OnMve,PlayerMovementSetting setting)
    {
        this.context = context;
        this.setting = setting;
        playerData = context.playerData;

        try
        {
            context.inputActions.Player.OnMove.performed -= OnMve;
            context.inputActions.Player.OnMove.canceled -= OnMve;
        }
        catch { }

        context.inputActions.Player.OnMove.performed += OnMve;
        context.inputActions.Player.OnMove.canceled += OnMve;
    }

    public Vector3 Mvement()
    {
        Vector3 velocity = setting.Velocity;
        //ÉJÉÅÉâÇÃå¸Ç´ÇéÊìæ
        Vector3 cameraFoward = Vector3.Scale(
            context.playerCamera.transform.forward,
            new Vector3(1, 0, 1)
            ).normalized;

        float zSpeed = (0 < setting.InputDirection.z) ?
            setting.Speed.Front : setting.Speed.Back;

        velocity = cameraFoward 
            * zSpeed 
            * setting.InputDirection.z;

        velocity += context.playerCamera.transform.right
            * setting.InputDirection.x
            * setting.Speed.Side;

        return velocity * Time.deltaTime;
    }
}

public class PlayerMovementSetting
{
    public Vector3 InputDirection { get; private set; }
    public Vector3 Velocity { get; private set; }
    public MoveSpeed Speed { get; private set; }
    public MotionCreator Creator { get; private set; }

    public void MovementSetting(Vector3 inputDirection, Vector3 velocity, MoveSpeed speed)
    {
        InputDirection = inputDirection;
        Velocity = velocity;
        Speed = speed;
    }
}
