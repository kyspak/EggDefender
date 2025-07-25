using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Scorecount;
public class Fox : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject Nest;
    private Transform target;
    void Awake()
    {
        target = Nest.transform;
    }
    private void OnMouseUp()
    {
        otmena();
    }
    void Destruction()
    {
        this.gameObject.name = "re12";
    }
    void otmena()
    {
        this.gameObject.name = "Fox(Clone)";
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name=="Nest" || collision.gameObject.name=="Warrior" || collision.gameObject.name=="snaryad(Clone)")
        {
            Destroy(this.gameObject);
            Score++;
        }
    }
    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {
        Destruction();
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
    void FixedUpdate()
    {
        if (this.gameObject.name=="Fox(Clone)")
        {
            float step = speed * Time.deltaTime;
            gameObject.transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }
}
