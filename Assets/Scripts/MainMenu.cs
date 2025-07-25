using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject template;
    public void Play(int index)
    {
        index++;
        SceneManager.LoadScene(index);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Rules()
    {
        Instantiate(template);
    }
}
