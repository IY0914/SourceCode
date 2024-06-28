using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigi : MonoBehaviour
{
    Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rb.AddForce(transform.forward * -100.0f);
    }
}
