using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PantherAnimatiorController : MonoBehaviour
{
    public Animator pAnimator;
    // Start is called before the first frame update
    void Start()
    {
        pAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        pAnimator.SetInteger("State", 2);
    }
}
