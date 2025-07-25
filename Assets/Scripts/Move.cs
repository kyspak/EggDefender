using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
       // Speed = 1.5;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var nearestEnemy = Enemy.FindClosestEnemy(transform.position);
        float Step = Speed * Time.deltaTime; // calculate distance to move
        gameObject.transform.position = Vector2.MoveTowards(transform.position, nearestEnemy.transform.position, Step);
    }
}
