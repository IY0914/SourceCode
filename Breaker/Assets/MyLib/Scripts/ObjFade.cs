using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjFade : MonoBehaviour
{

    MeshRenderer Mesh;

    // Start is called before the first frame update
    void Start()
    {
        //�}�e���A���̎擾
        Mesh = GetComponent<MeshRenderer>();
        //�����x��������O����
        StartCoroutine("Transparent");
    }

    IEnumerator Transparent()
    {
        //�J��Ԃ��œ����x�㏸
        for(int i = 0; i < 255; i ++)
        {
            Mesh.material.color = Mesh.material.color - new Color32(0, 0, 0, 5);
            
            yield return new WaitForSeconds(0.04f);
        }

       
    }
}