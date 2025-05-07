using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class frontsceneM : MonoBehaviour
{
    float time = 0;
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 2)
        {
            time = 0;
            speed = 0;
            SceneManager.LoadScene("ClearScene");
        }
    }
}
