using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10;
    private int jumpcount;
    SpriteRenderer player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody2D>();
        jumpcount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.flipX = false;
            Vector2 force = new Vector2(speed * 0.1f, 0);
            rb.AddForce(force, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.flipX = true;
            Vector2 force = new Vector2(speed * -0.1f, 0);
            rb.AddForce(force, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumpcount > 0)
        {
            Vector2 force = new Vector2(rb.velocity.x, 10f);
            rb.velocity = force;
        }

        if(rb.velocity.y == 0)
        {
            jumpcount = 2;
        }
        /*if (rb.velocity.x)
        {

        }*/
    }
    void FixedUpdate()
    {

    }
}
