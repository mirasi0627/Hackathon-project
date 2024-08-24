//hackathon_player
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5;
    public scorecounter Score;
    float y;
    private int jumplimit;
    SpriteRenderer player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody2D>();
        jumplimit = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.flipX = false;
            Vector2 force = new Vector2(speed * 4f, rb.velocity.y);
            rb.velocity = force;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Vector2 force = new Vector2(0f, rb.velocity.y);
            rb.velocity = force;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.flipX = true;
            Vector2 force = new Vector2(speed * -4f, rb.velocity.y);
            rb.velocity = force;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Vector2 force = new Vector2(0f, rb.velocity.y);
            rb.velocity = force;
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumplimit > 0)
        {
            Vector2 force = new Vector2(rb.velocity.x, 10f);
            rb.velocity = force;
            jumplimit--;
        }
        y = (float)Score.maxscore;
        if (this.transform.position.y < y - 10)
        {
            PlayerPrefs.SetFloat("resultscore", (float)Score.maxscore);
            SceneManager.LoadScene("result");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumplimit = 2;
    }
}
