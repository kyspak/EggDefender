using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mag : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Magicball;

    public Transform spawnPoint;
    public static GameObject clone;
    public float startTimeBtwSpawns;
    private float timeBtwSpawns;
    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
        spawnPoint = gameObject.transform;
    }

    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            Instantiate(Magicball, spawnPoint.transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
