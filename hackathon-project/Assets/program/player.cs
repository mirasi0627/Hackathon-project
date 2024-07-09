using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float speed = 1;
    static int count = 1;
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 force = new Vector2(speed * 0.1f, 0);
            rb.AddForce(force, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 force = new Vector2(speed * -0.1f, 0);
            rb.AddForce(force, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.Space) && count > 0)
        {
            //rb.velocity = Vector2.zero;
            Vector2 force = new Vector2(0, 1f);
            rb.AddForce(force, ForceMode2D.Impulse);
        }
    }
}
