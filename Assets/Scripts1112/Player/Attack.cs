using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public Transform FirePostition;
    public GameObject Projectile1;
    public GameObject Projectile2;
    public GameObject Projectile3;
    public GameObject Projectile4;

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
            Instantiate(Projectile1, FirePostition.position, FirePostition.rotation);
        }


        if (Input.GetButtonDown("Fire2"))

        {
            Instantiate(Projectile2, FirePostition.position, FirePostition.rotation);
        }

        if (Input.GetButtonDown("Fire3"))

        {
            Instantiate(Projectile3, FirePostition.position, FirePostition.rotation);
        }

        if (Input.GetButtonDown("Fire4"))

        {
            Instantiate(Projectile4, FirePostition.position, FirePostition.rotation);
        }
        
    }
}
