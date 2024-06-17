using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraManager : MonoBehaviour
{
    Collider2D moguraCollider;
    Animator animator;
    GameManager gameManager; //�ǋL
    AudioSource audioSource;
    public AudioClip pikopikoSE;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //�ǋL
        animator = GetComponent<Animator>();
        moguraCollider = GetComponent<Collider2D>();
        HideColliderMogura();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0.1f, 0);
    }
    public void HideColliderMogura()
    {
        moguraCollider.enabled = false;
        Debug.Log("���O���R���C�_�[��������");
    }
    public void ShowColliderMogura()
    {
        moguraCollider.enabled = true;
        Debug.Log("���O���R���C�_�[������");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //����邱�ƁA�U�����󂯂���A���_���ǉ������
        animator.SetTrigger("Hurt");
        audioSource.PlayOneShot(pikopikoSE);
        gameManager.AddScore(); //�ǋL
        HideColliderMogura();
        StartCoroutine(Damage());
    }
    IEnumerator Damage()
    {

        yield return new WaitForSeconds(0.5f);
        animator.enabled = false;
        yield return new WaitForSeconds(1.0f);
        animator.enabled = true;
        animator.Play("float@mogura");
    }

}