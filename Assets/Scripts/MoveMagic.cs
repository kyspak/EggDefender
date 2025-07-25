using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMagic : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(this.gameObject);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var nearestEnemy = Enemy.FindClosestEnemy(transform.position);
        float step = speed * Time.deltaTime; // calculate distance to move
        gameObject.transform.position = Vector2.MoveTowards(transform.position, nearestEnemy.transform.position, step);
    }
}