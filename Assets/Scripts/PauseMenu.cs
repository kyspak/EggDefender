using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static GameManager;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public void resume()
    {
        Destroy(this.gameObject);
        paused = false;
        Time.timeScale = 1;
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
