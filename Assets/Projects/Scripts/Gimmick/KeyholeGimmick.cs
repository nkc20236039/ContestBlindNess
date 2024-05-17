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

    public void CancelGimmick()
    {
        if (isFinish)
        {
            Debug.Log("このタスクは終了しています");
            return;
        }

        if (player.HasKeyType == type)
        {
            //TaskManegerに連絡
            Debug.Log("タスククリア");
            player.HasKeyType = KeyGimmickType.None;
            isFinish = true;
            return;
        }

        if (player.HasKeyType != type)
        {
            Debug.Log($"違うタイプです");
            return;
        }
    }

    public void StartGimmick(){}
    public void StopGimmick(){}
}
