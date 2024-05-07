using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContext
{
    public PlayerData playerData { get; }
    public PlayerInputAction inputActions { get; }
    public Rigidbody playerRigidbody { get; }
    public Transform playerHeadTransform { get; }
    public PlayerMovementSetting setting { get; set; }

    public PlayerContext(PlayerData playerData,PlayerInputAction inputActions,
        Rigidbody playerRigidbody,Transform playerHeadTransform, PlayerMovementSetting setting)
    {
        this.playerData = playerData;
        this.inputActions = inputActions;
        this.playerRigidbody = playerRigidbody;
        this.playerHeadTransform = playerHeadTransform;
        this.setting = setting;
    }
}
