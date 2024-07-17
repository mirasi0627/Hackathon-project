using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject time_object = null;
    float countTime, time;

    // Start is called before the first frame update
    void Start()
    {
        countTime = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Text time_text = time_object.GetComponent<Text>();
        time_text.text = "Žc‚èŽžŠÔ:" + countTime.ToString("f0") + "•b";
        countTime -= Time.deltaTime;

        if(countTime < 0)
        {
            SceneManager.LoadScene("result");
        }
    }
}
