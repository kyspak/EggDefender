using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Scorecount : MonoBehaviour

{
    public static int Score = 0;
    public Text ScoreText;

    public void Update()
    {
        ScoreText.GetComponent<Text>().text = "Score: " + Score.ToString();
    }

}