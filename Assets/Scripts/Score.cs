using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score = 10;
    public Text pScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //pScore.text = score.ToString();

        if (Input.GetMouseButtonDown(0))
        {
            score -= 5;
            pScore.text = score.ToString();
            //pScore.text = score.ToString("D4");
        }

        
    }

    /*
    public void setScore(int pScore)
    {
        score = pScore;
    }

    public int getScore()
    {
        return score;
    }

    public void setHScore(int h)
    {
        hScore = h;
    }

    public int getHScore()
    {
        return hScore;
    }
    */

}
