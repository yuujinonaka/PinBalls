﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosz = -6.5f;

    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;

	// Use this for initialization
	void Start ()
    {
        //シーンの中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
	}
	
	// Update is called once per frame
	void Update ()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosz)
        {
            //GameoverTextにゲーム―オーバを表示
            this.gameoverText.GetComponent<Text>().text = " GameOver";
        }
		
	}
}
