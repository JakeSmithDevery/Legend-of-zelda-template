using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Animator animator;
    float hor,vert;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");

        if(hor == 0 && vert == 0)
        {
            animator.Play("Idle");

        }
        else if (hor > 0)
        {
            animator.Play("Right");
        }
        else if (hor < 0)
        {
            animator.Play("Left");
        }
        else if (vert > 0)
        {
            animator.Play("Back");
        }
        else if (vert < 0)
        {
            animator.Play("Forward");
        }

    }
}
