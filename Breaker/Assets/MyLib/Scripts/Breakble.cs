using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakble : MonoBehaviour
{
    //����O�̃I�u�W�F�N�g
    [SerializeField] private Transform BrokenPrefab;

    //�ڑ����Ă���I�u�W�F�N�g�̏��擾
    Rigidbody JointObjects;

    //�ڑ����Ă��邩�ǂ���
    FixedJoint StartJoint;
    FixedJoint nowJoint;
    public bool JointONOFF = true;

    //�A���j��switch
    public bool BreakDestroy = false;


    private void Start()
    {
        if (nowJoint == null)
        {
            //Debug.Log("�Ȃ�");
            JointONOFF = false;
        }
        else
        {
            StartJoint = this.gameObject.GetComponent<FixedJoint>();
        }
    }

    private void Update()
    {
        if(nowJoint)
        nowJoint = this.gameObject.GetComponent<FixedJoint>();

        if (nowJoint == null)
        {
            //Debug.Log("�Ȃ�");
            JointONOFF = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "Weapon")
        {
            if (JointONOFF == true)
            {
                if (nowJoint.connectedBody == null)
                {
                    Destroy(nowJoint);
                    JointONOFF = false;
                }

            }


            //��ꂽ�I�u�W�F�N�g�Ɉʒu���Ɖ�]����
            //�^���邽�߂Ƀv���n�u�ʒu�Â���

            Debug.Log("��������");

            //�Ȃ����Ă���Ƃ���
            if (JointONOFF)
            {
                //�R�l�N�g�����I�u�W�F�N�g�̕������Z�i���W�b�h�{�f�B�j���擾
                JointObjects = nowJoint.connectedBody;

                //�R�l�N�g���Ă����I�u�W�F�N�g�ɏd�͂�������
                JointObjects.isKinematic = false;
                JointObjects.useGravity = true;

                //�ϊ���������������on�ɂ���
                foreach (Rigidbody rb in BrokenPrefab.GetComponentsInChildren<Rigidbody>())
                {
                    rb.isKinematic = false;
                    JointObjects.GetComponent<GameObject>().GetComponent<Breakble>().BreakDestroy = true;
                }
            }

            Transform brokenTrasform = Instantiate(BrokenPrefab, transform.position, transform.rotation);
            //��ꂽ���Ɋg�嗦����������
            //brokenTrasform.localScale = transform.localScale;

            //�q�R���|�[�l���g�̃��M�b�h�{�f�B�ɗ͂������邽�߂Ɏ擾
            //�������̂�Children��s��t����
            //foreach (Rigidbody rigitbody in brokenTrasform.GetComponentsInChildren<Rigidbody>())
            //{
            //    //���M�b�h�{�f�B�ɕ����Ƃ��̗͂�������
            //    rigitbody.AddExplosionForce(150.0f, transform.position + Vector3.up * 0.5f, 5.0f);

            //}


            //�����̔j��
            Destroy(gameObject);
        }
    }


    // Update is called once per frame

    //private void OnTriggerEnter(Collider other)
    //{
    //    // �Փ˂��������Player�^�O���t���Ă���Ƃ�
    //    if (other.gameObject.tag == "Weapon")
    //    {
    //        //��ꂽ�I�u�W�F�N�g�Ɉʒu���Ɖ�]����
    //        //�^���邽�߂Ƀv���n�u�ʒu�Â���

    //        Transform brokenTrasform = Instantiate(BrokenPrefab, transform.position, transform.rotation);
    //        //��ꂽ���Ɋg�嗦����������
    //        //brokenTrasform.localScale = transform.localScale;

    //        //�q�R���|�[�l���g�̃��M�b�h�{�f�B�ɗ͂������邽�߂Ɏ擾
    //        //�������̂�Children��s��t����
    //        foreach (Rigidbody rigitbody in brokenTrasform.GetComponentsInChildren<Rigidbody>())
    //        {
    //            //���������Ƃ�����v�Z
    //            Vector3 TriggerPoint = other.ClosestPointOnBounds(this.transform.position);

    //            Debug.Log(TriggerPoint);

    //            //���M�b�h�{�f�B�ɕ����Ƃ��̗͂�������
    //            rigitbody.AddExplosionForce(150.0f, transform.position + Vector3.up * 0.5f, 5.0f);

    //        }

    //        //�����̔j��
    //        Destroy(gameObject);
    //    }
    //}

}
