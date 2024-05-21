using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyholeGimmick : MonoBehaviour, IGimmick
{
    [SerializeField]
    KeyGimmickType type;
    //ほんとはIPlayerから持ってくる予定
    [SerializeField]
    Player.Player player;
    private bool isFinish;

    public void CancelGimmick(GameObject playerCamera)
    {
        if (isFinish)
        {
            return;
        }

        if (player.HasKeyType == type)
        {
            //TaskManegerに連絡
            Destroy(playerCamera.transform.GetChild(0).gameObject);
            player.HasKeyType = KeyGimmickType.None;
            isFinish = true;
            return;
        }

        if (player.HasKeyType != type)
        {
            return;
        }
    }

    public void StartGimmick(){}
    public void StopGimmick(){}
}
