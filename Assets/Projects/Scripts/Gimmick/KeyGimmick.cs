using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public enum KeyGimmickType
{
    None,
    Sphere,
    Square,
    Triangle
}

//ギミックの持てるほう
public class KeyGimmick : MonoBehaviour, IGimmick
{
    [SerializeField]
    KeyGimmickType type;
    //ほんとはIPlayerから持ってくる予定
    [SerializeField]
    Player.Player player;

    public void PlayGimmick()
    {
        Debug.Log($"{player.HasKeyType}から{type}に持ち替え");
        player.HasKeyType = type;       
        return;
    }
}
