//score
//Score_ Score, ÉvÉåÉCÉÑÅ[ hackathon_player
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour
{
    public GameObject score_object = null;
    public double maxscore;
    double score;
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
        score = Player_posi.y + 3.2;
        if (maxscore < score)
        {
            maxscore = score;
            Text score_text = score_object.GetComponent<Text>();
            score_text.text = "score:" + maxscore.ToString("f0") + "M";
        }
    }
    
}
