using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScripe : MonoBehaviour
{
    public Transform moveSpot;
    public float minX;
    public float minY;
    public float minZ;
    public float maxX;
    public float maxY;
    public float maxZ;
    public float cubeSpeed;

    public float stopTime;
    public float startWaitTime;
    public bool isMoving;
    
    // Start is called before the first frame update
    void Start()
    {
        isMoving = true;
        
        //moveSpot.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot.position, cubeSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, moveSpot.position) < 2.0f)
        {
            if (stopTime < 0)
            {
                isMoving = true;
                stopTime = startWaitTime;

                moveSpot.position = new Vector3(Random.Range(minX, maxX), 500, Random.Range(minZ, maxZ));
            }
            else
            {
                stopTime -= Time.deltaTime;
                isMoving = false;

            }
         }
     }
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Animal"))
    //    {
    //        isMoving = false;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    {
    //        if (other.CompareTag("Animal"))
    //        {
    //            isMoving = true;
    //        }
    //    }
    //}
}
