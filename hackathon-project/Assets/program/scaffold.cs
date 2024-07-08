using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Scaffold : MonoBehaviour
{

    public bool canChangeSize = false;
    public bool canDestroy = false;
    public float speed = 1.0f;
    public float changeSpeed = 1.0f;
    public int move_width = 1;
    public Vector3 size = new Vector3(1f, 0.5f, 1f);
    public Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        transform.localScale = size;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(pos.x + Mathf.PingPong(Time.time * speed, move_width), pos.y, pos.z);
        if (canChangeSize)
        {
            Vector3 new_size = size;
            new_size.x = size.x * Mathf.PingPong(Time.time * changeSpeed, 1.5f);
            transform.localScale = new_size;
        }
        else
        {
            transform.localScale = size;
        }

        GetComponent<BoxCollider2D>().size = new Vector2(size.x, size.y);


        if (!GetComponent<Renderer>().isVisible && canDestroy)
        {
            Destroy(this.gameObject);
        }
    }
}
