using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatunemiku : MonoBehaviour
{
    
    float time = 0;
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        speed = 0.1f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0); //�ړ�
        time += Time.deltaTime;
        if (time > 1)
        {
            //5�b���������邵���
            //�X�s�[�h�𔽓]������
            speed = -speed;

            //�^�C�}�̏�����
            time = 0;
        }
    }
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
