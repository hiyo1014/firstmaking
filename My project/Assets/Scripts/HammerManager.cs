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
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        Vector3 pos = Camera.main.ScreenToWorldPoint(mousePosition);
        pos.x *= (float)36.28;
        pos.y *= (float)36.28;
        pos.x += (float)242;
        pos.y += (float)181.4;
        hammerObject.transform.position = pos;

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Move0");
        }

    }

}