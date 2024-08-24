//component resultscore
//Score score
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    public GameObject score_object = null;
    float score;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetFloat("resultscore", 0);
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "score:" + score.ToString("f0") + "M";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
