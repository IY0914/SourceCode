using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    //消滅までの時間
    public float deltaTime = 3.0f;

    //地面に当たってから3秒で消滅
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
