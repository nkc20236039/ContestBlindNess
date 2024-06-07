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
    private GameObject obj;

    public void CancelGimmick(GameObject playerCamera)
    {
        if(playerCamera.transform.childCount != 0)
        {
            playerCamera.transform.GetChild(0).gameObject.transform.position
                = transform.position;
            playerCamera.transform.GetChild(0).gameObject.transform.rotation = Quaternion.identity;
            playerCamera.transform.GetChild(0).gameObject.transform.localScale = Vector3.one *2;
            playerCamera.transform.GetChild(0).gameObject.transform.parent = null;
        }
        player.HasKeyType = type;
        transform.parent = playerCamera.transform;
        transform.localPosition = player.HasKeyPoint;
        transform.localRotation = Quaternion.identity;
        transform.localScale = Vector3.one;
        return;
    }

    public void StartGimmick(){}
    public void StopGimmick(){}
}