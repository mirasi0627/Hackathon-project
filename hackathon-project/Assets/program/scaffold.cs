using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaffold : MonoBehaviour
{

    public bool canChangeSize = false;
    public float speed = 1.0f;
    public int move_width = 1;
    public Vector3 size = new Vector3(1f, 1f, 1f);
    public Vector3 pos;

    void Awake()
    {
        pos = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = size;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(pos.x + Mathf.PingPong(Time.time * speed, move_width), pos.y, pos.z);
        if (canChangeSize)
        {
            Vector3 new_size = size;
            new_size.x = size.x * Mathf.PingPong(Time.time, 1.5);
            transform.localScale = new_size;
        }
        else
        {
            transform.localScale = size;
        }
    }
}
