using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AnimatorController : MonoBehaviour
{
    public CubeScripe mm;
    public Animator animalAnimator;
    public NavMeshAgent ani;
   // int idle_01 = 0;
    //int dile_02 = 5;
    //Random r = new Random();
    //int[] animationArray = new int[] { 0, 5 };
    //int RandomNumber = r.Next(anmationArray.Length);
    //int ramdomAnimation = animationArray[ramdomNunber];
  void Start()
    {
        animalAnimator = GetComponent<Animator>();
        ani = GetComponent<NavMeshAgent>();
        transform.GetComponent<Rigidbody>();
     
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged)
        {
            animalAnimator.SetInteger("State", 2);
        }
        else
        {
            animalAnimator.SetInteger("State", 5);
        }
    }
}
