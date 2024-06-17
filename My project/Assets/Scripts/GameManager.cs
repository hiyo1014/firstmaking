using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public MoguraGenerator moguraGenerator1;
    public MoguraGenerator moguraGenerator2;
    public MoguraGenerator moguraGenerator3;
    public MoguraGenerator moguraGenerator4;
    public MoguraGenerator moguraGenerator5;
    public MoguraGenerator moguraGenerator6;

    public GameObject resultPanal;
    public TextMeshProUGUI LeftTimeText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI finalText;
    float LeftTime = 30;
    int score = 0;
    string playTime;

    void Start()
    {
        StartCoroutine("CreateMogura1");
        StartCoroutine("CreateMogura2");
        StartCoroutine("CreateMogura3");
        StartCoroutine("CreateMogura4");
        StartCoroutine("CreateMogura5");
        StartCoroutine("CreateMogura6");
        ScoreText.text = "得点：" + score;
        resultPanal.SetActive(false);
    }

    void Update()
        {
            playTime = System.DateTime.Now.ToString();//playtimeなくてもいい？

            //1秒に1秒ずつ減らしていく
            LeftTime -= Time.deltaTime;
            //マイナスは表示しない
            if (LeftTime < 0) LeftTime = 0;
            LeftTimeText.text = "残り時間：" + ((int)LeftTime).ToString();

            if (LeftTime == 0)
            {
                resultPanal.SetActive(true);
                finalText.text = ScoreText.text;
                //Debug.Log("時間になった");
                //Debug.Log(score);
                //Debug.Log(playTime);
            }

    }

    public void AddScore()
    {
        score += 10;

        ScoreText.text = "得点:" + score;
    }

    void InitScore()
    {
        //スコア初期化
        score = 0;
    }

    public void OnTitleButton()
    {
        SceneManager.LoadScene("Title");
        //SaveScore(score);
        InitScore();
    }

    public void OnRetryButton()
    {
        SceneManager.LoadScene("main");
        //SaveScore(score);
        InitScore();
    }

    IEnumerator CreateMogura1()
    {
        yield return new WaitForSeconds(0.5f); //0.5秒遅らせる
        moguraGenerator1.SpawnMogura();
    }
    IEnumerator CreateMogura2()
    {
        yield return new WaitForSeconds(1.0f); //1秒遅らせる
        moguraGenerator2.SpawnMogura();
    }
    IEnumerator CreateMogura3()
    {
        yield return new WaitForSeconds(1.5f); //1.5秒遅らせる
        moguraGenerator3.SpawnMogura();
    }
    IEnumerator CreateMogura4()
    {
        yield return new WaitForSeconds(2.0f); //0.5秒遅らせる
        moguraGenerator4.SpawnMogura();
    }
    IEnumerator CreateMogura5()
    {
        yield return new WaitForSeconds(2.5f); //1秒遅らせる
        moguraGenerator5.SpawnMogura();
    }
    IEnumerator CreateMogura6()
    {
        yield return new WaitForSeconds(3.0f); //1.5秒遅らせる
        moguraGenerator6.SpawnMogura();
    }
}