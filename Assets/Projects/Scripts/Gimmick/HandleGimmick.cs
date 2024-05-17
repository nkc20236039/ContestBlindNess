using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleGimmick : MonoBehaviour, IGimmick
{
    private bool isPlay;
    private float playTime;
    private float nowPlayTime;

    void Start()
    {
        isPlay = false;
        //UniRxでisPlayを条件にしてメソッドを呼ぶ
    }

    void PlayGimmick()
    {
        nowPlayTime += Time.deltaTime;

        if (nowPlayTime >= playTime)
        {
            //タスクを完了させる
        }
    }

    public void CancelGimmick()
    {
        isPlay = false;
    }

    public void StartGimmick()
    {
        isPlay = true;
    }

    public void StopGimmick()
    {
        isPlay = false;
    }
}
