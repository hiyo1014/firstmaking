using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text LeftTimeText;
    float LeftTime = 30;
    void Update()
        {
      
            //1秒に1秒ずつ減らしていく
            LeftTime -= Time.deltaTime;
            //マイナスは表示しない
            if (LeftTime < 0) LeftTime = 0;
            LeftTimeText.text = "残り時間：" + ((int)LeftTime).ToString(); 
        
        }
}