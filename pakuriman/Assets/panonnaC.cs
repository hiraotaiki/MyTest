using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class panonnaC : MonoBehaviour
{
    float time = 0;
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed, 0, 0);
        time += Time.deltaTime;
        if (time > 0.3f)
        {
            speed = 9f;

            if (time > 0.33f )
            {
                speed = 0.001f;         //speed += 5
               

            }
            if(time > 0.33f && time < 0.4f)
            {
                GetComponent<AudioSource>().Play();
            }
            if (time > 1f)
            {
                time = 0;
                speed = 0;
                SceneManager.LoadScene("gameover");
            }
        }

    }
}
