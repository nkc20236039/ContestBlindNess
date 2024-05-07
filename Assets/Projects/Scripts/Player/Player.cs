using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerStateType
{
    Idel,
    Move,
    Dash
}

public class Player : MonoBehaviour
{
    [ SerializeField]
    private PlayerData playerData;
    [SerializeField]
    private GameObject playerHead;

    private PlayerContext context;
    private StateMachine stateMachine;
    private PlayerInputAction inputAction;
    private Rigidbody playerRigidbody;
    private PlayerMouseMove mouseMove;
    private EchoProcess echoProcess;
    private PlayerMovementSetting setting;

    private void Awake()
    {
        inputAction = new PlayerInputAction();
        inputAction.Enable();
        playerRigidbody = GetComponent<Rigidbody>();
        setting = new PlayerMovementSetting();
    }

    private void Start()
    {
        context = new PlayerContext(playerData,inputAction,playerRigidbody,
            playerHead.transform,setting);
        stateMachine = new StateMachine(this);
        stateMachine.Register(PlayerStateType.Idel, new PlayerIdelState(context));
        stateMachine.Register(PlayerStateType.Move, new PlayerMoveState(context));
        stateMachine.Register(PlayerStateType.Dash, new PlayerDashState(context));
        stateMachine.Enable(PlayerStateType.Idel);
        mouseMove = new PlayerMouseMove(context);
        echoProcess = new EchoProcess(context);
        playerData.NowStamina = playerData.MaxStamina + 1;
    }

    private void Update()
    {
        stateMachine.CurrentState.OnUpdate();
        playerHead.transform.rotation = mouseMove.MouseMove();
        echoProcess.EchoCoolTime();
    }

    private void FixedUpdate()
    {
        stateMachine.CurrentState.OnFixedUpdate();
    }

    private void OnDestroy()
    {
        stateMachine.Disable();
        stateMachine = null;
    }
}
