using PlayerMotion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Parameter;

public class PlayerContext
{
    public PlayerData playerData { get; }
    public PlayerInputAction inputActions { get; }
    public Rigidbody playerRigidbody { get; }
    public GameObject playerHead { get; }
    public MotionCreator motionCreator { get; }

    public PlayerContext(PlayerData playerData,PlayerInputAction inputActions,Rigidbody playerRigidbody,GameObject playerHead, MotionCreator motionCreator)
    {
        this.playerData = playerData;
        this.inputActions = inputActions;
        this.playerRigidbody = playerRigidbody;
        this.playerHead = playerHead;
        this.motionCreator = motionCreator;
    }
}
