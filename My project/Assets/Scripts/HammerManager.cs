using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerManager : MonoBehaviour
{
    public GameObject hammerObject;
    Collider2D hammerCollider;
    Animator animator;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        hammerCollider = GetComponent<Collider2D>();
        HideColliderHammer();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.resultPanal.activeSelf == false)
        {
            ShowHammer();
            if (Input.GetMouseButtonDown(0))
            {
                animator.SetTrigger("Move0");
            }
        }
    }

    void ShowHammer()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        Vector3 pos = Camera.main.ScreenToWorldPoint(mousePosition);
        pos.x *= (float)36.28;
        pos.y *= (float)36.28;
        pos.x += (float)242;
        pos.y += (float)181.4;
        hammerObject.transform.position = pos;
    }

    //�A�j���[�V�����C�x���g�Ŏg�p�i�菇�D�ŉ���j
    public void HideColliderHammer()
    {
        hammerCollider.enabled = false;
        //Debug.Log("�n���}�[�R���C�_�[��������");
    }

    //�A�j���[�V�����C�x���g�Ŏg�p�i�菇�D�ŉ���j
    public void ShowColliderHammer()
    {
        hammerCollider.enabled = true;
        //Debug.Log("�n���}�[�R���C�_�[������");
    }

}
