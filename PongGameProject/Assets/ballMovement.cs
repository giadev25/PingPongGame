using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    GameObject player;
    GameObject bot;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bot = GameObject.FindGameObjectWithTag("bot");
        int random = Random.Range(0, 2);
        if(random == 0)
        {
            rb.velocity = new Vector2(-5f, 0f);   
        } 
        else if (random == 1)
        {
            rb.velocity = new Vector2(5f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float dist = transform.position.y - player.transform.position.y;
        float dist2 = transform.position.y - bot.transform.position.y;

        if(collision.gameObject.name == "Player")
        {
            rb.velocity = new Vector2(5f, dist);
        }
        if(collision.gameObject.name == "Bot")
        {
            rb.velocity = new Vector2(-5f, dist);
        }

        if(collision.gameObject.tag == "goal1")
        {
            Destroy(gameObject);
        }if(collision.gameObject.tag == "goal2")
        {
            Destroy(gameObject);
        }
    }
}
