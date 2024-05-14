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

//ƒMƒ~ƒbƒN‚Ì‚Ä‚é‚Ù‚¤
public class KeyGimmick : MonoBehaviour, IGimmick
{
    [SerializeField]
    KeyGimmickType type;
    //‚Ù‚ñ‚Æ‚ÍIPlayer‚©‚ç‚Á‚Ä‚­‚é—\’è
    [SerializeField]
    Player.Player player;

    public void PlayGimmick()
    {
        Debug.Log($"{player.HasKeyType}‚©‚ç{type}‚É‚¿‘Ö‚¦");
        player.HasKeyType = type;       
        return;
    }
}
