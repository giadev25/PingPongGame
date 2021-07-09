using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotScript : MonoBehaviour
{

    GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("ball");   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ballPosition = ball.transform.position;
        ballPosition.x = transform.position.x;
        ballPosition.z = transform.position.z;
        transform.position = ballPosition;
    }
}
