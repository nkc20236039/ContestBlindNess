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

//�M�~�b�N�̎��Ă�ق�
public class KeyGimmick : MonoBehaviour, IGimmick
{
    [SerializeField]
    KeyGimmickType type;
    //�ق�Ƃ�IPlayer���玝���Ă���\��
    [SerializeField]
    Player.Player player;

    public void CancelGimmick()
    {
        Debug.Log($"{player.HasKeyType}����{type}�Ɏ����ւ�");
        player.HasKeyType = type;
        return;
    }

    public void StartGimmick(){}
    public void StopGimmick(){}
}