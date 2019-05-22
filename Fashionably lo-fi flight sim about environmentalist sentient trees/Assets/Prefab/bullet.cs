using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
    
{
    public GameObject Enemy;
    
    public float power;



     void OnTriggerEnter(Collider col)
    {
        Enemy.GetComponent<Rigidbody>().AddForce(0, 0, power, ForceMode.Impulse);
        //if (col.CompareTag("Animal"))
        //{
          //  col.GetComponent<Transform>();
            //col.gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        //}
    }

}
