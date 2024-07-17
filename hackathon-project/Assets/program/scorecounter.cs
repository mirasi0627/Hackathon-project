using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class socorecounter : MonoBehaviour
{
    public GameObject score_object = null;
    double maxscore;
    public GameObject Player = null;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 Player_posi = Player.transform.position;
        maxscore = Player_posi.y + 3.2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Player_posi = Player.transform.position;
        if (maxscore < 3.2)
        {
            Text score_text = score_object.GetComponent<Text>();
            score_text.text = "score:" + (Player_posi.y + 3.2).ToString("f0") + "M";
        }
    }

    public double getScore()
    {
        double max = maxscore;
        return max;
    }
    
}
