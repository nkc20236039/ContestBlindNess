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


    private float currentStaina;
    public float CurrentStamina
    {
        get => currentStaina;

        set
        {
            currentStaina = Mathf.Clamp(value, 0, MaxStamina);
        }
    }

    public bool IsDisappear { get; set; }


    [SerializeField]
    private float echoDistance;
    public float EchoDistance => echoDistance;
    [SerializeField]
    private float echoSpped;
    public float EchoSpeed => echoSpped;
    [SerializeField]
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

    public bool IsPlayEcho { get; set; }

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
