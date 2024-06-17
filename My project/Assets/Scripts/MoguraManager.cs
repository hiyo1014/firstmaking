using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraManager : MonoBehaviour
{
    //���O���̃R���C�_�[��錾 �����蔻��Ɏg��
    Collider2D moguraCollider;
    //�A�j���[�^�[��錾 �A�j���[�V�����֌W�̊֐����s�Ɏg��
    Animator animator;
    //�I�[�f�B�I�\�[�X��錾
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
    //�A�j���[�V�����C�x���g�Ŏg�p�i�菇�D�ŉ���j
    public void HideColliderMogura()
    {
        moguraCollider.enabled = false;
        Debug.Log("���O���R���C�_�[��������");
    }
    //�A�j���[�V�����C�x���g�Ŏg�p�i�菇�D�ŉ���j
    public void ShowColliderMogura()
    {
        moguraCollider.enabled = true;
        Debug.Log("���O���R���C�_�[������");
    }

    //
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //����邱�ƁA�U�����󂯂���A���_���ǉ������
        //Hurt�Ɩ��t�����p�����[�^�������Ŋ�����
        animator.SetTrigger("Hurt");
        audioSource.PlayOneShot(pikopikoSE);
        HideColliderMogura();
        StartCoroutine(Damage());
    }
    //�_���[�W���󂯂鎞�̊֐�
    IEnumerator Damage()
    {
        yield return new WaitForSeconds(0.5f);
        animator.enabled = false;
        yield return new WaitForSeconds(1.0f);
        animator.enabled = true;
        animator.Play("float@mogura");
    }

}