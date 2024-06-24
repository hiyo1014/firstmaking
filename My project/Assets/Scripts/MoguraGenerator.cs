using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraGenerator : MonoBehaviour
{
    public GameObject moguraPrefab;
    public GameObject moguraPrefablv2;
    public GameObject moguraPrefablv3;
    public GameObject rabitPrefab;
    bool isThereMogura;
    GameObject monster;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //���O���𐶐�����֐�
    public void SpawnMogura()
    {
        int moguranum = UnityEngine.Random.Range(1, 11);
        if(5 > moguranum){
            monster = Instantiate(moguraPrefab);
        }else if(8 > moguranum && moguranum > 4){
            monster = Instantiate(moguraPrefablv2);
        }else if(9 > moguranum && moguranum > 7){
            monster = Instantiate(rabitPrefab);
        }else{
            monster = Instantiate(moguraPrefablv3);
        }

        monster.transform.SetParent(transform, false);
        isThereMogura = true;
        if (isThereMogura == true)
        {
            Debug.Log("����");
        }
    }

    public bool IsThereMogura()
    {
        return monster;
    }

}