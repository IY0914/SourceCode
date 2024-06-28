//Cursor.SetCursor(handCursor, Vector2.zero, CursorMode.Auto);
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // �R���d�v

public class Changemouse : MonoBehaviour
{
    public Texture2D handCursor;
    public Texture2D handClickCursor;
    void Start()
    {
        //Cursor.SetCursor(�摜,�J�[�\���̊�ʒu(new Vector2(�摜�̔����̑傫��)),�J�[�\���̕`����@(auto�̓J�[�\���̑傫���Q��,ForceSoftWere�͉摜�̑傫���Q��))
        Cursor.SetCursor(handCursor, new Vector2(78, 78), CursorMode.ForceSoftware);
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "TitleScene")
        { 
            if (Input.GetMouseButton(0))
            {
                Cursor.SetCursor(handClickCursor, new Vector2(78, 78), CursorMode.ForceSoftware);
                //�N���b�N�����特�Đ�
                GetComponent<AudioSource>().Play();
            }
            else
            {
                Cursor.SetCursor(handCursor, new Vector2(78, 78), CursorMode.ForceSoftware);
            }
        }
        else
        {
            //mouse�J�[�\�����f�t�H���g�ɕύX
            Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
        }
    }
}
