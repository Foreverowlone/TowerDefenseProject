using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickDestroy : MonoBehaviour
{
    public int score;
    public int health = 2;
    public int coinsTotal;
    public int coins;
    public Text purseCoins;
    public Text scoreTotal;
    public Slider healthStat;
    public GameObject defense;

    // Start is called before the first frame update
    void Start()
    {
        purseCoins = GameObject.Find("coinsTotal").GetComponent<Text>();
        healthStat = GameObject.Find("SliderHealth").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
            if (gameObject.tag == "EnemyA")
            {
                coins += 2;
            }
            if (gameObject.tag == "EnemyB")
            {
                coins += 3;
            }

            //scoreTotal.text = score.ToString();
        }
    }
}
