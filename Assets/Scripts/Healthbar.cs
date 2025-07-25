using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Healthbar : MonoBehaviour
{
    
    public static Transform coord;
    public Image Bar;
    public GameObject Fox;
    public float fill;
    public float hp;
    // Start is called before the first frame update
    void Start()
    {
        fill = 1f;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Fox(Clone)" || collision.gameObject.name=="re12")
        {
            fill -= float.Parse((Time.fixedDeltaTime * hp).ToString());
            Bar.fillAmount = fill;
            if (fill <= 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
