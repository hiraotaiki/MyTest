using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cheeseController : MonoBehaviour
{
    GameObject cheese;
    GameObject cow;
    public int index = 0; // 0は左上　1は右上　2は左下　3は右下



    //Vector3 p1;
    //Vector3 p2;
    // Start is called before the first frame update
    void Start()
    {
        this.cow = GameObject.Find("cow");
        this.cheese = GameObject.Find("cheese");
    }

    // Update is called once per frame
    void Update()
    {
        //当たり判定
        Vector3 p1 = transform.position;  //チーズの中心座標
        Vector3 p2 = cow.transform.position;  //牛の中心座標
        Vector3 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.1f;
        float r2 = 0.1f;

        if(d < r1 + r2 ) 
        {
            if (index == 0)
            {
                this.cheese.transform.Translate(11.5f, 0, 0);
                index = 1;

            }
            else if(index == 1)
            {
                this.cheese.transform.Translate(-11.5f, -8.6f, 0);
                index = 2;
            }
            else if(index == 2)
            {
                this.cheese.transform.Translate(11.5f, 0, 0);
                index = 3;
            }
            else if(index ==3)
            {
                SceneManager.LoadScene("frontscene");
            }
            
            
         }

        ////チーズとうしが当たったらきえる
        // void OnTriggerEnter2D(Collider2D collision)
        //{
        //    Destroy(this.gameObject);
        //}
    }
}
