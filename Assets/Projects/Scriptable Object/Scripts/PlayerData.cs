using Unity.VisualScripting;
using UnityEngine;

namespace Parameter
{
    public struct MoveSpeed
    {
        public float Front { get; }
        public float Back { get; }
        public float Side { get; }

        public MoveSpeed(float front, float back, float side)
        {
            Front = front;
            Back = back;
            Side = side;

        }
    }


    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Player")]
    public class PlayerData : ScriptableObject
    {
        [SerializeField]
        [Header("�O���̈ړ����x")]
        private float defaultFoward;
        [SerializeField]
        [Header("����̈ړ����x")]
        private float defaultBuck;
        [SerializeField]
        [Header("���E�̈ړ����x")]
        private float defaultSide;

        public MoveSpeed DefoltSpeed
            => new MoveSpeed(defaultFoward, defaultBuck, defaultSide);

        [SerializeField]
        [Header("�_�b�V�����̑O���̈ړ����x")]
        private float dashFoward;
        [SerializeField]
        [Header("�_�b�V�����̌���̈ړ����x")]
        private float dashBuck;
        [SerializeField]
        [Header("�_�b�V�����̍��E�̈ړ����x")]
        private float dashSide;

        public MoveSpeed DashSpeed
            => new MoveSpeed(dashFoward, dashBuck, dashSide);


        [SerializeField]
        [Header("�X�^�~�i�؂�̉񕜑��x")]
        private float expendStamina;
        public float ExpendStamina => expendStamina;
        [SerializeField]
        [Header("�ʏ�̃X�^�~�i�񕜑��x")]
        private float recoverStamina;
        public float RecoverStamina => recoverStamina;
        [SerializeField]
        [Header("�X�^�~�i�̃N�[���_�E��")]
        private float coolDownStamina;
        public float CooldownStamina => coolDownStamina;
        [SerializeField]
        [Header("�X�^�~�i�̍ő�l")]
        private float maxStamina;
        public float MaxStamina => maxStamina;

        private float currentCoolDown;
        public float CurrentCoolDown
        {
            get => currentCoolDown;

            set
            {
                currentCoolDown = Mathf.Clamp(value, 0, CooldownStamina);
            }
        }

        private float currentStaina;
        public float CurrentStamina
        {
            get => currentStaina;

            set
            {
                currentStaina = Mathf.Clamp(value, 0, MaxStamina);
            }
        }

        public bool IsDisappear { get => (0 == CurrentCoolDown); }


        [SerializeField]
        [Header("�G�R�[�̋���")]
        private float echoDistance;
        public float EchoDistance => echoDistance;
        [SerializeField]
        [Header("�G�R�[�̑���")]
        private float echoSpped;
        public float EchoSpeed => echoSpped;
        [SerializeField]
        [Header("�G�R�[�̎���")]
        private float echoCoolTime;
        public float EchoCoolTime => echoCoolTime;

        private float currentEchoCoolTime;
        public float CurrentEchoCoolTime
        {
            get => currentEchoCoolTime;

            set
            {
                currentEchoCoolTime = Mathf.Clamp(value, 0, MaxStamina);
            }
        }

        public bool IsPlayEcho => (0 > currentEchoCoolTime);

        [SerializeField]
        [Header("�c�̊��x")]
        private float verticalSpeed;
        public float VerticalSpeed => verticalSpeed;
        [SerializeField]
        [Header("���̊��x")]
        private float horizontalSpeed;
        public float HorizontalSpeed => horizontalSpeed;

        [SerializeField]
        [Header("�C���^���N�g�̋���")]
        private float interactDistance;
        public float InteractDistance => interactDistance;
    }
}