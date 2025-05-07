using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    GameObject enemy1;
    GameObject gyaru;
    GameObject mizugi;
    GameObject innkya;
    GameObject hatunemiku;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.enemy1 = GameObject.Find("enemy1");
        this.gyaru = GameObject.Find("gyaru");
        this.mizugi = GameObject.Find("mizugi");
        this.innkya = GameObject.Find("innkya");
        this.hatunemiku = GameObject.Find("hatunemiku");
    }

    // Update is called once per frame
    void Update()
    {
        //左矢印が押された時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0); //左に１動かす
        
        }

        //右矢印が押された時
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);  //右に１動かす
        }
        //上矢印が押された時
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.1f, 0);  //上に１動かす
        }
        //下矢印が押された時
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.1f, 0); //したに１動かす
        }

        {//当たり判定
            Vector3 p1 = transform.position;  //牛の中心座標
            Vector3 p2 = (enemy1.transform.position);  //敵の中心座標
            Vector3 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.5f;
            float r2 = 0.5f;

            if (d < r1 + r2)
            {
                SceneManager.LoadScene("katscene");
                Debug.Log("aa");
            }
        }

        { //当たり判定
            Vector3 p1 = transform.position;  //牛の中心座標
            Vector3 p2 = (gyaru.transform.position);  //敵の中心座標
            Vector3 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.5f;
            float r2 = 0.5f;

            if (d < r1 + r2)
            {
                SceneManager.LoadScene("katscene");
            }
        }
        { //当たり判定
            Vector3 p1 = transform.position;  //牛の中心座標
            Vector3 p2 = (mizugi.transform.position);  //敵の中心座標
            Vector3 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.5f;
            float r2 = 0.5f;

            if (d < r1 + r2)
            {
                SceneManager.LoadScene("katscene");
            }
        }
        { //当たり判定
            Vector3 p1 = transform.position;  //牛の中心座標
            Vector3 p2 = (innkya.transform.position);  //敵の中心座標
            Vector3 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.45f;
            float r2 = 0.45f;

            if (d < r1 + r2)
            {
                SceneManager.LoadScene("katscene");
            }
        }
        { //当たり判定
            Vector3 p1 = transform.position;  //牛の中心座標
            Vector3 p2 = (hatunemiku.transform.position);
            Vector3 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.45f;
            float r2 = 0.45f;

            if (d < r1 + r2)
            {
                SceneManager.LoadScene("katscene");
            }
        }








    }


}
