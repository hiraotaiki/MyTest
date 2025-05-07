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
        //当たり判定
        Vector2 p1 = transform.position; //壁の中心座標
        Vector2 p2 = cow.transform.position; //cowの中心座標
        Vector2 dir = p1- p2;
        float d = dir.magnitude;
        float r1 = 0.1f; //壁の半径
        float r2 = 0.05f; //cowの半径

        if(d < r1 + r2)
        {
            //衝突した場合は矢を消す
            Debug.Log("aaa");
        }
    }
}
