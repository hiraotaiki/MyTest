using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyaruController : MonoBehaviour
{
    float time = 0;
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        speed = 0.04f;
            

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, this.speed, 0); //�ړ�
        time += Time.deltaTime;
        if(time > 3)
        {
            time = 0;  //�^�C���̏�����
            speed = -speed; //�@�t�ɐi��

        }

      



    }
}
