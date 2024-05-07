using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMouseMove
{
    private PlayerData playerData;
    private Vector2 inputDirection;
    private Vector3 lookDirection;
    private const float MAX_MOVE = 45;
    private const float MIN_MOVE = -35;

    public PlayerMouseMove(PlayerContext context)
    {
        this.playerData = context.playerData;

        context.inputActions.Player.OnMouseMove.performed += OnMouseMove;
        context.inputActions.Player.OnMouseMove.canceled += OnMouseMove;
    }

    public Quaternion MouseMove()
    {
        lookDirection = new Vector3(
            inputDirection.x * playerData.HorizontalSpeed,
            inputDirection.y * playerData.VerticalSpeed,
            0);

        lookDirection.y = Mathf.Clamp(lookDirection.y, MIN_MOVE, MAX_MOVE);
        return Quaternion.Euler(-lookDirection.y, lookDirection.x, 0);
    }

    public void OnMouseMove(InputAction.CallbackContext context)
    {
        inputDirection = context.ReadValue<Vector2>();
    }
}
