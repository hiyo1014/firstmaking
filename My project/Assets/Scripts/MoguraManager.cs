using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraManager : MonoBehaviour
{
    //モグラのコライダーを宣言 当たり判定に使う
    Collider2D moguraCollider;
    //アニメーターを宣言 アニメーション関係の関数実行に使う
    Animator animator;
    //オーディオソースを宣言
    AudioSource audioSource;
    public AudioClip pikopikoSE;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        moguraCollider = GetComponent<Collider2D>();
        HideColliderMogura();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0.1f, 0);
    }
    //アニメーションイベントで使用（手順⑤で解説）
    public void HideColliderMogura()
    {
        moguraCollider.enabled = false;
        Debug.Log("モグラコライダーが消えた");
    }
    //アニメーションイベントで使用（手順⑤で解説）
    public void ShowColliderMogura()
    {
        moguraCollider.enabled = true;
        Debug.Log("モグラコライダーがついた");
    }

    //
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //次やること、攻撃を受けたら、得点が追加される
        //Hurtと名付けたパラメータがここで活きる
        animator.SetTrigger("Hurt");
        audioSource.PlayOneShot(pikopikoSE);
        HideColliderMogura();
        StartCoroutine(Damage());
    }
    //ダメージを受ける時の関数
    IEnumerator Damage()
    {
        yield return new WaitForSeconds(0.5f);
        animator.enabled = false;
        yield return new WaitForSeconds(1.0f);
        animator.enabled = true;
        animator.Play("float@mogura");
    }

}