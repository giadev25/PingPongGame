using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            Debug.Log("Oushh..");
        }    
    }
}

