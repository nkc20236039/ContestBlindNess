using Alchemy.Inspector;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName ="Data/Player")]
public class PlayerData : ScriptableObject
{
    [Title("�ʏ�ړ��̃p�����[�^�[")]
    [LabelText("�O���ړ��̑��x"),SerializeField, TabGroup("�ړ�","�ʏ�")]
    private float fowardSpeed;
    public float FowardSpeed => fowardSpeed;
    [LabelText("����ړ��̑��x"), SerializeField]
    private float buckSpeed;
    public float BuckSpeed => buckSpeed;
    [LabelText("���E�̈ړ�"), SerializeField]
    private float sideSpeed;
    public float SideSpeed => sideSpeed;

    [Title("�_�b�V���̃p�����[�^�[")]
    [LabelText("�����x"), SerializeField,TabGroup("�ړ�", "�_�b�V��")]
    private float dashSpeed;
    public float DashSpeed => dashSpeed;
    [LabelText("�X�^�~�i�̏���x"), SerializeField, TabGroup("�ړ�", "�_�b�V��")]
    private float expendStamina;
    public float ExpendStamina => expendStamina;
    [LabelText("�ʏ펞�̃X�^�~�i�̉񕜑��x"), SerializeField, TabGroup("�ړ�", "�_�b�V��")]
    private float recoverStamina;
    public float RecoverStamina => recoverStamina;
    [LabelText("�N�[���_�E�����̃X�^�~�i�̉񕜑��x"), SerializeField, TabGroup("�ړ�", "�_�b�V��")]
    private float coolDownStamina;
    public float CooldownStamina => coolDownStamina;
    [LabelText("�X�^�~�i�̍ő�l"), SerializeField, TabGroup("�ړ�", "�_�b�V��")]
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


    [Title("�G�R�[�̃p�����[�^�[")]
    [LabelText("�G�R�[�̍ő�˒�"), SerializeField]
    private float echoDistance;
    public float EchoDistance => echoDistance;
    [LabelText("�G�R�[�̑��x"), SerializeField]
    private float echoSpped;
    public float EchoSpeed => echoSpped;
    [LabelText("�G�R�[�̃N�[���^�C��"), SerializeField]
    private float echoCoolTime;
    public float EchoCoolTime => echoCoolTime;


    [Title("�}�E�X�̊��x")]
    [LabelText("�c�̊��x"), SerializeField]
    private float verticalSpeed;
    public float VerticalSpeed => verticalSpeed;
    [LabelText("���̊��x"), SerializeField]
    private float horizontalSpeed;
    public float HorizontalSpeed => horizontalSpeed;

    [Title("���̑�")]
    [LabelText("�C���^���N�g�ł��鋗��"), SerializeField]
    private float interactDistance;
    public float InteractDistance => interactDistance;
}
