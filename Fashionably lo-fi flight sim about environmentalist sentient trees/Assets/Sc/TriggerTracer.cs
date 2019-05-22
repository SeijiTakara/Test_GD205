using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TriggerTracer : MonoBehaviour
{
    public NavMeshAgent agent;
    public TestAIPar1 tP;
    public AnimalDeath aDeath;
    public AudioSource jiaosheng;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        tP = GetComponent<TestAIPar1>();
        tP.enabled = true;
    }

    void Update()
    {
        if (aDeath.isDead)
        {
            tP.enabled = true;
        }
    }


    void OnTriggerStay(Collider other)
    {
       
        if (other.CompareTag("Animal"))
        {
            agent.destination = other.transform.position;
            tP.enabled = false;
            if (Vector3.Distance(transform.position, other.transform.position) < 6f)
            {
                other.transform.localScale -= new Vector3(0.003f, 0.003f, 0.003f);
                transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
                jiaosheng.Play();
            }
        }
    }
   void OnTriggerExit(Collider other)
    {
        tP.enabled = true;
    }
}
