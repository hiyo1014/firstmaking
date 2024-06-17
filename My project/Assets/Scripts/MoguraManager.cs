using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraManager : MonoBehaviour
{
    Collider2D moguraCollider;
    Animator animator;
    GameManager GameManager; //追記
    AudioSource audioSource;
    public AudioClip pikopikoSE;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //追記
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
        //Debug.Log("モグラコライダーが消えた");
    }
    public void ShowColliderMogura()
    {
        moguraCollider.enabled = true;
        //Debug.Log("モグラコライダーがついた");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //次やること、攻撃を受けたら、得点が追加される
        Debug.Log("Hurt");
        animator.SetTrigger("Hurt");
        audioSource.PlayOneShot(pikopikoSE);
        GameManager.AddScore(); //追記
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