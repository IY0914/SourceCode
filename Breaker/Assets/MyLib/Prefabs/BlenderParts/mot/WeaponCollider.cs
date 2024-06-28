using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class WeaponCollider : MonoBehaviour
    {
        private float impulseMagnitude;

        // Start is called before the first frame update
        void Start()
        {
            //�Փˎ��ɔ���������͐ς̑傫��
            this.impulseMagnitude = 70.0f;
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter(Collision collision)
        {
            //�Փˑ����Rigidbody���A�^�b�`���������̂ŁA�ʓr�󂩂�~�点��
            var rigid = collision.gameObject.GetComponent<Rigidbody>();

            //�Փˑ���̍��W�����]���S�̍��W
            var impulse = (rigid.position - transform.parent.position).normalized * this.impulseMagnitude;

            //�u�ԓI�ȏՌ���������ꍇ(�͐ς�������ꍇ)��ForceMode.Impulse���g��
            rigid.AddForce(impulse, ForceMode.Impulse);
        }
    }
}
