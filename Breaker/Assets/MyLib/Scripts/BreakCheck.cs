using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreakCheck : MonoBehaviour
{
    //�j��\�I�u�W�F�N�g������z��
    private GameObject[] BreakObjects;

    //�e�L�X�g���b�V���v��
    public TextMeshProUGUI BreakPersent;

    //�p�[�Z���e�[�W�������悤
    public static float Persent = 0.0f;
    float S_Object = 0;
    bool check = false;
    public static float PersentSum = 0.0f;

    //�X���C�_�[�p
    Slider BreakSd;
    public int sliderMax = 100;
    public int sliderMin = 0;

    // Start is called before the first frame update
    void Start()
    {
        BreakSd = GetComponent<Slider>();
        BreakSd.maxValue = sliderMax;
        BreakSd.minValue = sliderMin;
    }

    // Update is called once per frame
    void Update()
    {
        //�I�u�W�F�N�g�̃^�O�̐ݒ�
        TagCheck("Object");

        if (!check)
        {
            //�����̃I�u�W�F�N�g����ێ�
            S_Object = (float)BreakObjects.Length;
            //�������̔j��|�C���g�̌v�Z
            Persent = 100/ S_Object;
            check = true;
        }
    }

    //�^�O����v���Ă�����
    public void TagCheck(string TagName)
    {
        //�z��Ƀ^�O���t���Ă�����̂�����
        BreakObjects = GameObject.FindGameObjectsWithTag(TagName);

        //�p�[�Z���e�[�W�̌v�Z
        PersentSum = (Persent * (float)BreakObjects.Length);

        PersentSum = 100.0f - PersentSum;

        //�^�O�̂����I�u�W�F�N�g�̌����O�Ȃ�
        if (BreakObjects.Length == 0)
        {
            Debug.Log("�S���j��");
            SceneManager.LoadScene("ResultScene");
        }
        else
        {
            if(PersentSum >= 99.1f)
            {
                PersentSum = 100;
                //�p�[�Z���e�[�W�\��
                BreakPersent.text = (int)PersentSum + "%";
            }
            else
            {
                BreakPersent.text = (int)PersentSum + "%";
            }
        }

        BreakSd.value = PersentSum;
       // Debug.Log(PersentSum);
    }

    public float Score()
    {
        return PersentSum;
    }
}
