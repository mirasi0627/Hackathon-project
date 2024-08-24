//timer
//Time_ Timer, �X�R�A score
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject time_object = null;
    public float countTime, time;
    public scorecounter Score;
    public int increasingTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        countTime = 60;
        InvokeRepeating(nameof(Event), 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Text time_text = time_object.GetComponent<Text>();
        time_text.text = "�c�莞��:" + countTime.ToString("f0") + "�b";
        countTime -= Time.deltaTime;

        if (countTime < 0)
        {
            PlayerPrefs.SetFloat("resultscore", (float)Score.maxscore);
            SceneManager.LoadScene("result");
        }
    }

    void Event()
    {
        int randomValue = Random.Range(1, 101);

        if (randomValue <= 10)
        {
            countTime += increasingTime;
        }
    }
}
