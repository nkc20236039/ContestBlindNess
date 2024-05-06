using Alchemy.Inspector;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName ="Data/Player")]
public class PlayerData : ScriptableObject
{
    [Title("通常移動のパラメーター")]
    [LabelText("前方移動の速度"),SerializeField, TabGroup("移動","通常")]
    private float fowardSpeed;
    public float FowardSpeed => fowardSpeed;
    [LabelText("後方移動の速度"), SerializeField]
    private float buckSpeed;
    public float BuckSpeed => buckSpeed;
    [LabelText("左右の移動"), SerializeField]
    private float sideSpeed;
    public float SideSpeed => sideSpeed;

    [Title("ダッシュのパラメーター")]
    [LabelText("加速度"), SerializeField,TabGroup("移動", "ダッシュ")]
    private float dashSpeed;
    public float DashSpeed => dashSpeed;
    [LabelText("スタミナの消費速度"), SerializeField, TabGroup("移動", "ダッシュ")]
    private float expendStamina;
    public float ExpendStamina => expendStamina;
    [LabelText("通常時のスタミナの回復速度"), SerializeField, TabGroup("移動", "ダッシュ")]
    private float recoverStamina;
    public float RecoverStamina => recoverStamina;
    [LabelText("クールダウン中のスタミナの回復速度"), SerializeField, TabGroup("移動", "ダッシュ")]
    private float coolDownStamina;
    public float CooldownStamina => coolDownStamina;
    [LabelText("スタミナの最大値"), SerializeField, TabGroup("移動", "ダッシュ")]
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


    [Title("エコーのパラメーター")]
    [LabelText("エコーの最大射程"), SerializeField]
    private float echoDistance;
    public float EchoDistance => echoDistance;
    [LabelText("エコーの速度"), SerializeField]
    private float echoSpped;
    public float EchoSpeed => echoSpped;
    [LabelText("エコーのクールタイム"), SerializeField]
    private float echoCoolTime;
    public float EchoCoolTime => echoCoolTime;


    [Title("マウスの感度")]
    [LabelText("縦の感度"), SerializeField]
    private float verticalSpeed;
    public float VerticalSpeed => verticalSpeed;
    [LabelText("横の感度"), SerializeField]
    private float horizontalSpeed;
    public float HorizontalSpeed => horizontalSpeed;

    [Title("その他")]
    [LabelText("インタラクトできる距離"), SerializeField]
    private float interactDistance;
    public float InteractDistance => interactDistance;
}
