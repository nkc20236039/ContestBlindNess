using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class HandleGimmick : MonoBehaviour, IGimmick
{
    private bool isPlay;
    [SerializeField]
    [Header("�M�~�b�N�̍쓮����")]
    private float playTime;
    private float nowPlayTime;
    IDisposable disposable;

    void Start()
    {
        isPlay = false;
        disposable = this.UpdateAsObservable().Where(_ => isPlay == true).
            Subscribe(_ => PlayGimmick()).AddTo(this);
    }

    void PlayGimmick()
    {
        nowPlayTime += Time.deltaTime;
        if (nowPlayTime >= playTime)
        {
            //�^�X�N������������
            disposable.Dispose();
        }
    }

    public void CancelGimmick(GameObject ga)
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
