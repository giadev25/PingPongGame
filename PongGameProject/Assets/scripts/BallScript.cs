using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
      launc();  
    } 

    private void launc()
    {
        float x = UnityEngine.Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
