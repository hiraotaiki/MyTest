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
        //½è»è
        Vector2 p1 = transform.position; //ÇÌSÀW
        Vector2 p2 = cow.transform.position; //cowÌSÀW
        Vector2 dir = p1- p2;
        float d = dir.magnitude;
        float r1 = 0.1f; //ÇÌ¼a
        float r2 = 0.05f; //cowÌ¼a

        if(d < r1 + r2)
        {
            //ÕËµ½êÍîðÁ·
            Debug.Log("aaa");
        }
    }
}
