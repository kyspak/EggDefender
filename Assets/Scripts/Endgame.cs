using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Scorecount;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{
    public Text ScoreText;
    void Start()
    {
        ScoreText.GetComponent<Text>().text = "Score: " + Score.ToString();
        Score = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
