using UnityEngine;
using UnityEngine.UI;
using static PauseMenu;

public class GameManager : MonoBehaviour
{
    public Button pause;
    public static bool paused;
    public GameObject template;
    public GameObject[] Fox;
    public static Transform target;
    public Transform[] spawnPoint;
    public static GameObject clone;
    private int rand;
    private int randPosition;
    public float startTimeBtwSpawns;
    private float timeBtwSpawns;
    public float starttime;
    public float removetime;
    private float ntime;
    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
        ntime = starttime;
    }

public void Pause()
    {
            Time.timeScale = 0;
            paused = true;
            Instantiate(template);
            pause.interactable = false;
    }
    void Update()
    {
        if (timeBtwSpawns <=0)
        {
            rand = Random.Range(0, Fox.Length);
            randPosition = Random.Range(0, spawnPoint.Length);
            clone = Instantiate(Fox[rand], spawnPoint[randPosition].transform.position, Quaternion.identity) as GameObject;
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
        if (ntime <= 0)
        {
            if (startTimeBtwSpawns <= 0.6)
            {
                removetime = 0;
            }
            else
            {
                ntime = starttime;
                startTimeBtwSpawns = startTimeBtwSpawns - removetime;
            }
        }
        else
        {
            ntime -= Time.deltaTime;
        }
        if (paused == false)
        {
            pause.interactable = true;
        }
       
    }
}
