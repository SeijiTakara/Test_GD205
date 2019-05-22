using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalDeath : MonoBehaviour
{
    public GameObject Animal;
    public bool isDead;
    public AudioSource boomSound;
    public GameObject TextMes;
    public WinLoseCondition wlc;

    
    void Start()
    {
        isDead = false;
        TextMes.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Animal.GetComponent<Transform>().localScale.x < 0.01f || Animal.GetComponent<Transform>().localScale.x > 4f)
        {
           
            isDead = true;
            
        }
        if (Animal.GetComponent<Transform>().localScale.x > 3.5f)
        {
            TextMes.SetActive(true);
        }
        if(Animal.GetComponent<Transform>().localScale.x < 3.5f)
        {
            TextMes.SetActive(false);
        }
        if (isDead)
        {
            StartCoroutine(DeathShow());
            
        }

    }
    IEnumerator DeathShow()
    {
        boomSound.Play();
        yield return new WaitForSeconds(0.2f);
        Destroy(Animal);
        wlc.sheepCount -= 1;

    }
}
