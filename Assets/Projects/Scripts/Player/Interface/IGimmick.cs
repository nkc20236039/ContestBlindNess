using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGimmick
{
    /// <summary>
    /// �{�^���������ꂽ�Ƃ�
    /// </summary>
    public void StartGimmick();

    /// <summary>
    /// �M�~�b�N���~�߂����Ƃ�
    /// </summary>
    public void StopGimmick();

    /// <summary>
    /// �{�^���������ꂽ�Ƃ�
    /// </summary>
    public void CancelGimmick();
}
