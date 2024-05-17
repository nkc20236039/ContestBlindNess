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

    public void CancelGimmick()
    {
        if (isFinish)
        {
            Debug.Log("���̃^�X�N�͏I�����Ă��܂�");
            return;
        }

        if (player.HasKeyType == type)
        {
            //TaskManeger�ɘA��
            Debug.Log("�^�X�N�N���A");
            player.HasKeyType = KeyGimmickType.None;
            isFinish = true;
            return;
        }

        if (player.HasKeyType != type)
        {
            Debug.Log($"�Ⴄ�^�C�v�ł�");
            return;
        }
    }

    public void StartGimmick(){}
    public void StopGimmick(){}
}
