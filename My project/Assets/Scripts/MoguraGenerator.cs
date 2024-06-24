using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraGenerator : MonoBehaviour
{
    public GameObject moguraPrefab;
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
    //ƒ‚ƒOƒ‰‚ğ¶¬‚·‚éŠÖ”
    public void SpawnMogura()
    {
        monster = Instantiate(moguraPrefab);
        monster.transform.SetParent(transform, false);
        isThereMogura = true;
        if (isThereMogura == true)
        {
            Debug.Log("¬Œ÷");
        }
    }

    public bool IsThereMogura()
    {
        return monster;
    }

}