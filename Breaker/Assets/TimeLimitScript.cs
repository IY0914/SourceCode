using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class TimeLimitScript : MonoBehaviour
{
    //�e�L�X�g���b�V���v���p��public�ϐ�
    public TextMeshProUGUI TimeText;

    //int�^�ϊ��p�ϐ�
    public float TimeLimit = 120.0f;

    private void Update()
    {
        //���Ԃ��J�E���g����
        TimeLimit -= Time.deltaTime;

        //���Ԃ�\������
        //TimeText.text = TimeLimit.ToString("f1") + "�b";

        if(TimeLimit <= 0.0f)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
