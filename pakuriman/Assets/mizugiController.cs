using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mizugiController : MonoBehaviour
{
    GameObject cow;
    float time = 0;
    float speed =0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        speed = 0.05f;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0); //�ړ�
        time += Time.deltaTime;
        if(time >3)
        {
            //5�b���������邵���
            //�X�s�[�h�𔽓]������
            speed = -speed;
            
            //�^�C�}�̏�����
            time = 0;
        }
    }
}
