using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement
{
    private PlayerContext context;
    private PlayerData playerData;
    private PlayerMovementSetting setting;

    public PlayerMovement(PlayerContext context,
        Action<InputAction.CallbackContext> OnMve)
    {
        this.context = context;
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
        //ƒJƒƒ‰‚ÌŒü‚«‚ðŽæ“¾
        Vector3 cameraFoward = Vector3.Scale(
            context.playerHeadTransform.forward,
            new Vector3(1, 0, 1)
            ).normalized;

        float zSpeed = (0 > setting.InputDirection.z) ?
            playerData.FowardSpeed : playerData.BuckSpeed;

        velocity = cameraFoward 
            * zSpeed 
            * setting.InputDirection.z;

        velocity += context.playerHeadTransform.right
            * setting.InputDirection.x
            * playerData.SideSpeed;

        return velocity;
    }
}

public class PlayerMovementSetting
{
    public Vector3 InputDirection { get; private set; }
    public Vector3 Velocity { get; private set; }

    public void MovementSetting(Vector3 inputDirection, Vector3 velocity)
    {
        InputDirection = inputDirection;
        Velocity = velocity;
    }
}
