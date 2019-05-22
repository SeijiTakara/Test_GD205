using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public Animator animalAnimator;
    public AudioSource Heal;

     void Start()
    {
        animalAnimator = GetComponent<Animator>();   
    }
    private void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("bullet"))
        {
            gameObject.transform.localScale+= new Vector3(0.001f, 0.001f, 0.001f);
            animalAnimator.SetInteger("State", 1);
            Heal.Play();
        }
    }

    
}
