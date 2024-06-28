using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLimitTex : MonoBehaviour
{
    //���ߍ��킹�p�摜
    public Image timeFillAmount;
    //��������
    public float timeLimit;
    //0.1������̊p�x
    private float radian = 0;
    //fill�̒l
    private float fillNum = 0;
    //���Ԍo��
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        //�摜���ߍ��킹�̐��l
        fillNum = 1.0f / (timeLimit * 60.0f);

        //�}�C�i�X�l
        radian = -360.0f / (timeLimit * 60.0f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        Vector3 rotation = new Vector3(0.0f, 0.0f, radian * Time.deltaTime);

        timeFillAmount.fillAmount = fillNum * time;

        transform.Rotate(rotation);
    }
}
