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
        //UniRx��isPlay�������ɂ��ă��\�b�h���Ă�
    }

    void PlayGimmick()
    {
        nowPlayTime += Time.deltaTime;

        if (nowPlayTime >= playTime)
        {
            //�^�X�N������������
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
