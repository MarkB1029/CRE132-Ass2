
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class projectiles : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;

    public float projectileSpeed;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * projectileSpeed;

    }

    // Update is called once per frame
    void Update()
    {


    }

}
