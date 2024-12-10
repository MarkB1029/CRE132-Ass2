using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class projectile_Behaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public float lifetime = 5f;
    private float horizontal;
    private float damage;

    public float Speed = 4.5f;
    [SerializeField] private float physicsFireDamage;
    [SerializeField] private float physicsFireSpeed;

    public Transform FirePostition;


// Start is called before the first frame update
void Start()
    {
        Destroy(gameObject, lifetime);
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.right * Time.deltaTime * Speed;


    }




}
