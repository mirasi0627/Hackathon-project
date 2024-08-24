//Main Camera
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerahoming : MonoBehaviour
{
    public GameObject Player = null;
    float max_y;

    // Start is called before the first frame update
    void Start()
    {
        max_y = Player.transform.position.y;
        transform.position = new Vector3(transform.position.x, Player.transform.position.y, transform.position.z);

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(max_y < Player.transform.position.y)
        {
            max_y = Player.transform.position.y;
            transform.position = new Vector3(transform.position.x, Player.transform.position.y, transform.position.z);
        }
    }
}
