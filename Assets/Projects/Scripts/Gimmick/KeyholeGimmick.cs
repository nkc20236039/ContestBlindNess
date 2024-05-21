using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyholeGimmick : MonoBehaviour, IGimmick
{
    [SerializeField]
    KeyGimmickType type;
    //‚Ù‚ñ‚Æ‚ÍIPlayer‚©‚ç‚Á‚Ä‚­‚é—\’è
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
            //TaskManeger‚É˜A—
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
