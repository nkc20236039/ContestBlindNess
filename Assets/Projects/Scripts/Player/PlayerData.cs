using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Player")]
public class PlayerData : ScriptableObject
{
    [SerializeField]
    private float fowardSpeed;
    public float FowardSpeed => fowardSpeed;
    [SerializeField]
    private float buckSpeed;
    public float BuckSpeed => buckSpeed;
    [SerializeField]
    private float sideSpeed;
    public float SideSpeed => sideSpeed;

    [SerializeField]
    private float dashSpeed;
    public float DashSpeed => dashSpeed;
    [SerializeField]
    private float expendStamina;
    public float ExpendStamina => expendStamina;
    [SerializeField]
    private float recoverStamina;
    public float RecoverStamina => recoverStamina;
    [SerializeField]
    private float coolDownStamina;
    public float CooldownStamina => coolDownStamina;
    [SerializeField]
    private float maxStamina;
    public float MaxStamina => maxStamina;


    private float nowStaina;
    public float NowStamina
    {
        get => nowStaina;

        set
        {
            if (value < 0f)
            {
                nowStaina = 0;
                IsDisappear = true;
            }
            else if (MaxStamina < value)
            {
                nowStaina = MaxStamina;
                IsDisappear = false;
            }
            else
            {
                nowStaina = value;
            }
        }
    }

    public bool IsDisappear { get; private set; }


    [SerializeField]
    private float echoDistance;
    public float EchoDistance => echoDistance;
    [SerializeField]
    private float echoSpped;
    public float EchoSpeed => echoSpped;
    [SerializeField]
    private float echoCoolTime;
    public float EchoCoolTime => echoCoolTime;

    private float nowEchoCoolTime;
    public float NowEchoCoolTime
    {
        get => nowEchoCoolTime;

        set
        {
            if (value <= 0f)
            {
                nowEchoCoolTime = 0f;
                IsPlayEcho = false;
            }
            else if(EchoCoolTime < value)
            {
                nowEchoCoolTime = echoCoolTime;
                IsPlayEcho = true;
            }
            else
            {
                nowEchoCoolTime = value;
            }
        }
    }

    public bool IsPlayEcho { get; private set; }

    [SerializeField]
    private float verticalSpeed;
    public float VerticalSpeed => verticalSpeed;
    [SerializeField]
    private float horizontalSpeed;
    public float HorizontalSpeed => horizontalSpeed;

    [SerializeField]
    private float interactDistance;
    public float InteractDistance => interactDistance;
}
