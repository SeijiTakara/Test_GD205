using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPanther : MonoBehaviour
{
    public AudioSource hitSound;
    public AudioSource killSoundPanther;
    public GameObject pantherBody;
    public bool pDead;
    public WinLoseCondition wlc;
    void Start()
    {
        pDead = false;   
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            pantherBody.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
            hitSound.Play();
        }
    }
   void Update()
    {
        if (pantherBody.GetComponent<Transform>().localScale.x < 0.3f)
        {
            pDead = true;

        }
        if (pDead)
        {
            StartCoroutine(pDeadShowing());
        }
    }
    IEnumerator pDeadShowing()
    {
        killSoundPanther.Play();
        yield return new WaitForSeconds(0.1f);
        Destroy(pantherBody);
        wlc.enemiesCount -= 1;
    }
}
