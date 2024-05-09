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
        [Header("前方の移動速度")]
        private float defaultFoward;
        [SerializeField]
        [Header("後方の移動速度")]
        private float defaultBuck;
        [SerializeField]
        [Header("左右の移動速度")]
        private float defaultSide;

        public MoveSpeed DefoltSpeed
            => new MoveSpeed(defaultFoward, defaultBuck, defaultSide);

        [SerializeField]
        [Header("ダッシュ時の前方の移動速度")]
        private float dashFoward;
        [SerializeField]
        [Header("ダッシュ時の後方の移動速度")]
        private float dashBuck;
        [SerializeField]
        [Header("ダッシュ時の左右の移動速度")]
        private float dashSide;

        public MoveSpeed DashSpeed
            => new MoveSpeed(dashFoward, dashBuck, dashSide);


        [SerializeField]
        [Header("スタミナ切れの回復速度")]
        private float expendStamina;
        public float ExpendStamina => expendStamina;
        [SerializeField]
        [Header("通常のスタミナ回復速度")]
        private float recoverStamina;
        public float RecoverStamina => recoverStamina;
        [SerializeField]
        [Header("スタミナのクールダウン")]
        private float coolDownStamina;
        public float CooldownStamina => coolDownStamina;
        [SerializeField]
        [Header("スタミナの最大値")]
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
        [Header("エコーの距離")]
        private float echoDistance;
        public float EchoDistance => echoDistance;
        [SerializeField]
        [Header("エコーの速さ")]
        private float echoSpped;
        public float EchoSpeed => echoSpped;
        [SerializeField]
        [Header("エコーの時間")]
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
        [Header("縦の感度")]
        private float verticalSpeed;
        public float VerticalSpeed => verticalSpeed;
        [SerializeField]
        [Header("横の感度")]
        private float horizontalSpeed;
        public float HorizontalSpeed => horizontalSpeed;

        [SerializeField]
        [Header("インタラクトの距離")]
        private float interactDistance;
        public float InteractDistance => interactDistance;
    }
}