using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //�Ǐ]�p
    //�Ǐ]����I�u�W�F�N�g
    public GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //��l�̎��_
        this.gameObject.transform.position = targetObject.transform.position;
        this.gameObject.transform.rotation = targetObject.transform.rotation;
    }
}
