using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCasol : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //�}�E�X�̒ǔ�
        this.gameObject.transform.position = Input.mousePosition;
        //�}�E�X�̔�\��
        Cursor.visible = false;
    }
}
