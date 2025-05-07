using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    GameObject cow;
    Vector3 p1;
    Vector3 p2;
    // Start is called before the first frame update
    void Start()
    {
        this.cow = GameObject.Find("cow");
        Application.targetFrameRate= 60;
    }

    // Update is called once per frame
    void Update()
    {
        p1 = transform.position; //ìGÇÃç¿ïW
        p2 = this.cow.transform.position; //Ç§ÇµÇÃç¿ïW

        Vector3 direction = p2 - p1;

        transform.position = transform.position + direction / 40;

    }
}
