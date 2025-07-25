using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    public readonly static HashSet<Enemy> Pool = new HashSet<Enemy>();

    private void OnEnable()
    {
        Enemy.Pool.Add(this);
    }

    private void OnDisable()
    {
        Enemy.Pool.Remove(this);
    }



    public static Enemy FindClosestEnemy(Vector3 pos)
    {
        Enemy result = null;
        float dist = float.PositiveInfinity;
        var e = Enemy.Pool.GetEnumerator();
        while (e.MoveNext())
        {
            float d = (e.Current.transform.position - pos).sqrMagnitude;
            if (d < dist)
            {
                result = e.Current;
                dist = d;
            }
        }
        return result;
    }
}