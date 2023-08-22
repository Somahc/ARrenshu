using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    // 制限時間
    [SerializeField] int timeLimit;

    // タイマー用テキスト
    [SerializeField] Text timerText;

    // 経過時間
    float time;

    void Update()
    {
        //フレーム毎の経過時間をtime変数に追加
        time += Time.deltaTime;
        //time変数をint型にし制限時間から引いた数をint型のlimit変数に代入
        int remaining = timeLimit - (int)time;

        if(remaining < 1)
        {
            timerText.text = "終了";
        }
        else
        {
            //timerTextを更新していく
            timerText.text = $"残り{remaining.ToString("D3")}秒";
        }
    }
}
