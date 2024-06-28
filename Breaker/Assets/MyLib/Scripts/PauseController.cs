using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject Panel;

    //�|�[�Y��ʂɂ���
    public void PauseGame()
    {
        Time.timeScale = 0;
        this.Panel.SetActive(true);
    }

    //�|�[�Y��ʉ���
    public void ReStartGame()
    {
        Time.timeScale = 1;
        this.Panel.SetActive(false);
    }

    //�X�e�[�W�Z���N�g��ʂɖ߂�
    public void BackStage()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StageSelectScene");
    }

    //�^�C�g����ʂɖ߂�
    public void BackTitle()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TitleScene");
    }
}