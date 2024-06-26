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
    public TitleManager title;

    public GameObject resultPanal;
    public TextMeshProUGUI LeftTimeText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI finalText;
    public TextMeshProUGUI BestScoreText;
    float LeftTime = 30;
    string playTime;
    public int score = 0;



    void Start()
    {
        InitScore();
        StartCoroutine("CreateMogura1");
        StartCoroutine("CreateMogura2");
        StartCoroutine("CreateMogura3");
        StartCoroutine("CreateMogura4");
        StartCoroutine("CreateMogura5");
        StartCoroutine("CreateMogura6");
        ScoreText.text = "得点：" + score;
        int beScore = PlayerPrefs.GetInt("BESTSCORE");
        BestScoreText.text = "BestScore:" + beScore;
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

    public void SaveScore()
    {
       int resultScore = PlayerPrefs.GetInt("BESTSCORE");
       if (score > resultScore){
            PlayerPrefs.SetInt("BESTSCORE", score);
            PlayerPrefs.Save();
       }
    }
     

    public void AddScore(int point)
    {
        score += point;
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
        SaveScore();
        InitScore();
    }

    public void OnRetryButton()
    {
        SceneManager.LoadScene("main");
        SaveScore();
        InitScore();
    }

    IEnumerator CreateMogura1()
    {
        yield return null;
        while (true)
        {
            yield return null;
            if (moguraGenerator1.IsThereMogura() == false)
            {
                yield return new WaitForSeconds(Random.Range(0.5f, 5.0f)); //0.5秒遅らせる
                moguraGenerator1.SpawnMogura();
            }
        }
    }
    IEnumerator CreateMogura2()
    {
        yield return null;
        while (true)
        {
            yield return null;
            if (moguraGenerator2.IsThereMogura() == false)
            {
                yield return new WaitForSeconds(Random.Range(0.5f, 5.0f)); //0.5秒遅らせる
                moguraGenerator2.SpawnMogura();
            }
        }
    }
    IEnumerator CreateMogura3()
    {
        yield return null;
        while (true)
        {
            yield return null;
            if (moguraGenerator3.IsThereMogura() == false)
            {
                yield return new WaitForSeconds(Random.Range(0.5f, 5.0f)); //0.5秒遅らせる
                moguraGenerator3.SpawnMogura();
            }
        }
    }
    IEnumerator CreateMogura4()
    {
        yield return null;
        while (true)
        {
            yield return null;
            if (moguraGenerator4.IsThereMogura() == false)
            {
                yield return new WaitForSeconds(Random.Range(0.5f, 5.0f)); //0.5秒遅らせる
                moguraGenerator4.SpawnMogura();
            }
        }
    }
    IEnumerator CreateMogura5()
    {
        yield return null;
        while (true)
        {
            yield return null;
            if (moguraGenerator5.IsThereMogura() == false)
            {
                yield return new WaitForSeconds(Random.Range(0.5f, 5.0f)); //0.5秒遅らせる
                moguraGenerator5.SpawnMogura();
            }
        }
    }
    IEnumerator CreateMogura6()
    {
        yield return null;
        while (true)
        {
            yield return null;
            if (moguraGenerator6.IsThereMogura() == false)
            {
                yield return new WaitForSeconds(Random.Range(0.5f, 5.0f)); //0.5秒遅らせる
                moguraGenerator6.SpawnMogura();
            }
        }
    }
}