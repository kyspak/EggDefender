using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public void CloseWindow()
    {
        Destroy(this.gameObject);
    }
}
