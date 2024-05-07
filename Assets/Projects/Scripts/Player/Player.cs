using Alchemy.Inspector;
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
    [LabelText("プレイヤーのデータ"), SerializeField]
    private PlayerData playerData;
    [LabelText("プレイヤーの頭"), SerializeField]
    private GameObject playerHead;

    private PlayerContext context;
    private StateMachine stateMachine;
    private PlayerInputAction inputAction;
    private Rigidbody playerRigidbody;
    private PlayerMouseMove mouseMove;
    private EchoProcess echoProcess;

    private void Start()
    {
        inputAction = new PlayerInputAction();
        inputAction.Enable();
        playerRigidbody = GetComponent<Rigidbody>();
        context = new PlayerContext(playerData,inputAction,playerRigidbody,playerHead.transform);
        stateMachine = new StateMachine(this);
        stateMachine.Register(PlayerStateType.Idel, new PlayerIdelState(context));
        stateMachine.Register(PlayerStateType.Move, new PlayerMoveState(context));
        stateMachine.Register(PlayerStateType.Dash, new PlayerDashState(context));
        stateMachine.Enable(PlayerStateType.Idel);
        mouseMove = new PlayerMouseMove(context);
        echoProcess = new EchoProcess(context);
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
