using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    GameObject cow;

    // Start is called before the first frame update
    void Start()
    {
        this.cow = GameObject.Find("cow");
    }

    // Update is called once per frame
    void Update()
    {
        //�����蔻��
        Vector2 p1 = transform.position; //�ǂ̒��S���W
        Vector2 p2 = cow.transform.position; //cow�̒��S���W
        Vector2 dir = p1- p2;
        float d = dir.magnitude;
        float r1 = 0.1f; //�ǂ̔��a
        float r2 = 0.05f; //cow�̔��a

        if(d < r1 + r2)
        {
            //�Փ˂����ꍇ�͖������
            Debug.Log("aaa");
        }
    }
}
