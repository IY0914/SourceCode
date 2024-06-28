using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�ړ��p���M�b�h
    Rigidbody rb;
    //�A�j���[�V����
    Animator anim;
    //�ړ��X�s�[�h
    public float speed = 3.0f;
    //�W�����v��
    public float JumpPower = 5.0f;
    //�L�[���͎擾�p�ϐ�
    float InputHorizontal = 0.0f;
    float InputVertical = 0.0f;
    float InputSpace = 0.0f;
    //���s�L�[��������Ă�����
    bool WalkKey = false;
    bool JumpKey = false;
    bool AttackKey = false;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        AttackKey = false;
        //{�J�����̈ʒu�Ɋ�Â��ăv���C���[�̌��������߂Ĉړ�}
        //------------------------------------------------------------------------------------------------------//
        ////���ړ�����
        //InputHorizontal = Input.GetAxisRaw("Horizontal");
        ////�c�ړ����� 
        //InputVertical = Input.GetAxisRaw("Vertical");
        ////�W�����v����
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    JumpKey = true;
        //}
        //�U������
        if(Input.GetMouseButton(0))
        {
            AttackKey = true;
        }
        //------------------------------------------------------------------------------------------------------//


        AnimationController();
        //m_TurnAmount = Mathf.Atan2(move.x, move.z);
    }

    private void AnimationController()
    {

        anim.SetBool("Attack", AttackKey);
        //anim.SetFloat("Forward", rb.velocity.z, 0.1f, Time.deltaTime);
        //anim.SetFloat("Turn", m_TurnAmount, 0.1f, Time.deltaTime);
        //anim.SetBool("Crouch", m_Crouching);
        //anim.SetBool("OnGround", m_IsGrounded);
        //if (!m_IsGrounded)
        //{
        //    anim.SetFloat("Jump", rb.velocity.y);
        //}
    }

    private void FixedUpdate()
    {
        //{�J�����̈ʒu�Ɋ�Â��ăv���C���[�̌��������߂Ĉړ�}
        //------------------------------------------------------------------------------------------------------//
        //�J������������ɕ����x�N�g���̎擾
        Vector3 cameraFoward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        //�ړ����͂ƃJ�����̕�������ɕ�������(��+�c)
        Vector3 moveForward = Camera.main.transform.right * InputHorizontal + cameraFoward * InputVertical;

        //�ړ������ɃX�s�[�h�������đ��x���o��,�W�����v�Ȃǂ�����ꍇ��y�����Z
        rb.velocity = moveForward * speed + new Vector3(0, rb.velocity.y, 0);

        //�L�����N�^�[�̌�����i�s����
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }
        //------------------------------------------------------------------------------------------------------//
    }
}