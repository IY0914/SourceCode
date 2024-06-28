using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountObjects : MonoBehaviour
{
    //�q�I�u�W�F�N�g�̃I�u�W�F�N�g���擾
    //List���ƒǉ����ȒP�ɂł���(Unity�͂�������)
    public List<Rigidbody> Parts;
    
    //�z��̏������̏ꍇ�͊����̃I�u�W�F�N�g�����Ă����̂ɂ͖��ɗ��H
    //public Rigidbody[] Parts;

    // Update is called once per frame
    void Start()
    {
        //�������Z���擾
        foreach (Rigidbody obj in this.gameObject.GetComponentsInChildren<Rigidbody>())
        {
            Parts.Add(obj);
        }
    }

    private void Update()
    {
        //�L�l�}�e�B�b�N�̐����擾
        int kinematicIsFalse = 0;

        //�q�I�u�W�F�N�g�̐�����
        for(int i = 0; i < Parts.Count; i++)
        {
            //���𐔂��Ď擾
            if (Parts[i].isKinematic)
            {
                kinematicIsFalse++;
                Debug.Log(kinematicIsFalse);
            }
        }
        


        //������ꂽ��S���j��
        if (kinematicIsFalse <= Parts.Count / 1.5)
        {
            for(int i = 0; i < Parts.Count; i++)
            { 
               Parts[i].isKinematic = false;
            }
        }
    }
}
