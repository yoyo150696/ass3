using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <1){
            Destroy(gameObject);
        }
        
    }
}
