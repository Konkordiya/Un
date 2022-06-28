using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animr : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("ST", true);
        }
        else
        {
            anim.SetBool("ST", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }
    }
}
