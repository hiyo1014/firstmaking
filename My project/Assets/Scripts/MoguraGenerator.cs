using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraGenerator : MonoBehaviour
{
    public GameObject moguraPrefab;
    bool isThereMogura, checker;
    GameObject monster;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("UpdateMogura");
    }

    // Update is called once per frame
    void Update()
    {
        if (monster)
        {
            checker = true;
        }
    }
    //モグラを生成する関数
    public void SpawnMogura()
    {
        monster = Instantiate(moguraPrefab);
        monster.transform.SetParent(transform, false);
        isThereMogura = true;
        if (isThereMogura == true)
        {
            Debug.Log("成功");
        }
    }

    public bool GetIsThereMogura()
    {
        return isThereMogura;
    }

    IEnumerator UpdateMogura()
    {
        while(true)
        {
            checker = false;
            yield return new WaitForSeconds(5.0f); //0.5秒遅らせる
            if (checker == false)
            {
                isThereMogura = false;
                Debug.Log("not exist");
            }
            else
            {
                Debug.Log("exist");
            }
        }
    }

}