using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text> ();

        scoreValue = 0;
    }

    void Update (){
        score.text = "Score: " + scoreValue;
    }
}