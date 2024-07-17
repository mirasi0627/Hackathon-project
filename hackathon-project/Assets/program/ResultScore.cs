using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    public GameObject score_object = null;

    // Start is called before the first frame update
    void Start()
    {

        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "score:" + (3.2).ToString("f0") + "M";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
