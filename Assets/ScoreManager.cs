using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour { 

    public GameObject score_object = null;
    private int used_ball_num = 0;
    private int score_num = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "使ったボールの数: " + used_ball_num +"\n当たった数: " +
            score_num;
    }

    public void BallUsed()
    {
        used_ball_num++;
    }

    public void AddScore()
    {
        score_num++;
    }
}
