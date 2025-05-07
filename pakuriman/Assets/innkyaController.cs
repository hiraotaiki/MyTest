using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class innkyaController : MonoBehaviour
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
        transform.Translate(this.speed, 0, 0);
        time += Time.deltaTime;
        if(time > 3)
        {
            speed = 0.1f;
            
            
            if(time > 3.3)
            {
                speed = -speed;
             
            }
            if(time > 3.6f)
            {
                time = 0;
                speed = 0;
            }
        }
        //if(time = 0)
      
        
    }
}
