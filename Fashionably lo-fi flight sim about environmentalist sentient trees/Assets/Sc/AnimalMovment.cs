using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovment : MonoBehaviour
{
    public float moveSpeed;
    public float stopTime;
    public float startWaitTime;

    public Transform moveSpot;
    public float minX;
    public float minY;
    public float minZ;
    public float maxX;
    public float maxY;
    public float maxZ;
    public Animator animalAnimator;
    // Start is called before the first frame update
    void Start()
    {
        animalAnimator = GetComponent<Animator>();
        stopTime = startWaitTime;
        moveSpot.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot.position, moveSpeed * Time.deltaTime);
        animalAnimator.SetInteger("State", 2);
        if (Vector3.Distance(transform.position, moveSpot.position) < 0.2f)
        {
            if (stopTime <= 0)
            {

                moveSpot.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
                stopTime = startWaitTime;
                animalAnimator.SetInteger("State", 0);
            }
            else
            {
                stopTime -= Time.deltaTime;
            }
        }
    }
}
