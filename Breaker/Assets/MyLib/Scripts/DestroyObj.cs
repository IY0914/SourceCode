using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    //���ł܂ł̎���
    public float deltaTime = 3.0f;

    //�n�ʂɓ������Ă���3�b�ŏ���
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject, deltaTime);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject, deltaTime);
    }

    private void Update()
    {
        
    }
}
