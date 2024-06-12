using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerManager : MonoBehaviour
{
    public GameObject hammerObject;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        Debug.Log(mousePosition);
        var pos = Camera.main.ScreenToWorldPoint(mousePosition);
        Debug.Log(pos);
        hammerObject.transform.position = pos;

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Move0");
        }

    }

}