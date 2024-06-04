using PlayerMotion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Parameter;
using Player.State;

namespace Player
{
    public enum PlayerStateType
    {
        Idel,
        Move,
        Dash,
        Debug
    }

    public class Player : MonoBehaviour,IPlayer
    {
        [SerializeField]
        private PlayerData playerData;
        [SerializeField]
        private GameObject playerHead;
        [SerializeField]
        private GameObject mainCamera;
        [SerializeField]
        private PlayerDebugWindow playerDebugWindow;

        private PlayerContext context;
        private StateMachine stateMachine;
        private PlayerInputAction inputAction;
        private Rigidbody playerRigidbody;
        public Rigidbody PlayerRigidbody => playerRigidbody;
        private PlayerMouseMove mouseMove;
        private EchoProcess echoProcess;
        private GimmickProcess gimmickProcess;
        private MotionCreator motionCreator;

        private KeyGimmickType hasGimickType = KeyGimmickType.None;
        public KeyGimmickType HasKeyType { get; set; }
        public Vector3 HasKeyPoint => playerData.HasKeyPoint;

        private void Awake()
        {
            inputAction = new PlayerInputAction();
            inputAction.Enable();
            playerRigidbody = GetComponent<Rigidbody>();
            motionCreator = new MotionCreator();
        }

        private void Start()
        {
            context = new PlayerContext(playerData, inputAction, playerRigidbody, mainCamera, motionCreator);
            stateMachine = new StateMachine(this);
            stateMachine.Register(PlayerStateType.Idel, new PlayerIdelState(context));
            stateMachine.Register(PlayerStateType.Move, new PlayerMoveState(context));
            stateMachine.Register(PlayerStateType.Dash, new PlayerDashState(context));
#if DEBUG
            stateMachine.Register(PlayerStateType.Debug, new PlayerDebugState(context));
#endif

            stateMachine.Enable(PlayerStateType.Idel);
            mouseMove = new PlayerMouseMove(context);
            echoProcess = new EchoProcess(context);
            gimmickProcess = new GimmickProcess(context);
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
}


