using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire0: MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))

        {
            anim.SetBool("Fire", true);
        }
        else
        {
            anim.SetBool("Fire", false);
        }
    }
}
