using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleManager : MonoBehaviour
{
    public TextMeshProUGUI BestScore;
    AudioSource audioSource;
    // Start is called before the first frame update

   

    void Start()
    {
        int bestScoreVal = PlayerPrefs.GetInt("BESTSCORE");
        BestScore.text = "BestScore:" + bestScoreVal;
        //audioSource = GetComponent<AudioSource>();
        //audioSource.Play();
    }

    public void OnStartButton()
    {
        SceneManager.LoadScene("main");
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}