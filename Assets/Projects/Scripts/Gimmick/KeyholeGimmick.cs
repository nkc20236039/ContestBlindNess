using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyholeGimmick : MonoBehaviour, IGimmick
{
    [SerializeField]
    KeyGimmickType type;
    //�ق�Ƃ�IPlayer���玝���Ă���\��
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
            //TaskManeger�ɘA��
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
