using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    private int hScore = 0;
    public Text pScore;
    public Text hText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pScore.text = score.ToString("D4");
        hText.text = hScore.ToString("D4");

        pScore.text = score.ToString();

        if (score > hScore)
        {
            hScore = score;
        }
    }

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

}
