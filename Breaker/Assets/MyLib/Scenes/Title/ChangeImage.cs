using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Sprite _on;
    public Sprite _off;
    private bool flg = true;

    public void changeImage()
    {
        //�C���[�W���擾
        var img = GetComponent<Image>();
        //�摜�̏����t���O�ŊǗ�
        img.sprite = (flg) ? _on : _off;
        flg = !flg;

        //�摜���I�����ꂽ��
        if(_on)
        {
            //���ʉ�
            GetComponent<AudioSource>().Play();
            //�ԐF�ɐ��߂�
            img.color = Color.red;
            //Cursor.visible = false;
        }
    }
}

