using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger:MonoBehaviour
{
    public GameObject score_object = null;//Textオブジェクト
    public int score = 0;//スコア変数

    //初期化
    void Start()
    {
        score = 0;
        
    }

    //ボールと衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallCloudTag")
        {
            score += 50;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 100;
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 200;
        }

        

    }

    // 更新
    void Update()
    {
        //オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        //テキストの表示を入れ替える
        score_text.text = "Score:" + score;



    }
}
