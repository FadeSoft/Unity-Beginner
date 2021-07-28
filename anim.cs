using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public Animator animator,failAnimator,successAnimator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("trigger");
            animator.SetBool("bool", false);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("bool", true);
            animator.SetFloat("float", 50f);
            animator.ResetTrigger("trigger");
        }

    }
}
