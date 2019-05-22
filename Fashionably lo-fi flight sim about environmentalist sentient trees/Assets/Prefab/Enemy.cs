using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    public GameObject itself;
    
    void OnTriggerEnter(Collider col)
    {
        float dist = Vector3.Distance(bullet.transform.position, itself.transform.position);
        if (col.gameObject.CompareTag("bullet"))
        {
            Destroy(gameObject);
        }
      
    }
}
