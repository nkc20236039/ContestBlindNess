using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGimmick
{
    /// <summary>
    /// ボタンが押されたとき
    /// </summary>
    public void StartGimmick();

    /// <summary>
    /// ギミックを止めたいとき
    /// </summary>
    public void StopGimmick();

    /// <summary>
    /// ボタンが離されたとき
    /// </summary>
    public void CancelGimmick();
}
