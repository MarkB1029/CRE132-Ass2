using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currentPoint;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPoint = PointB.transform;
        flip();  // Allows the penguin to flip on start
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;  // Penguin walk from point to point 
        if (currentPoint == PointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointB.transform) // When they hit a point, they flip and head to next point
        {
            flip();
            currentPoint = PointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointA.transform)
        {
            flip();
            currentPoint = PointB.transform;
        }
    }

    private void flip()  // Flips when the penguin touches a point
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnDrawGizmos()  // Allows the points to be seen
    {
        Gizmos.DrawWireSphere(PointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(PointB.transform.position, 0.5f);
        Gizmos.DrawLine(PointA.transform.position, PointB.transform.position);
    }
}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Rendering;

//public class EnemyPatrol : MonoBehaviour
//{
//    public GameObject PointA;
//    public GameObject PointB;
//    private Rigidbody2D rb;
//    private Animator anim;
//    private Transform currentPoint;
//    public float speed;
//    private bool IsFacingRight;
//    // Start is called before the first frame update
//    void Start()
//    {
//        IsFacingRight = true;
//        rb = GetComponent<Rigidbody2D>();
//        anim = GetComponent<Animator>();
//        currentPoint = PointB.transform;
//        Flip();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        Vector2 point = currentPoint.position - transform.position;
//        if (currentPoint == PointB.transform)
//        {
//            rb.velocity = new Vector2(speed, 0);
//        }
//        else
//        {
//            rb.velocity = new Vector2(-speed, 0);
//        }

//        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointB.transform)
//        {
//            currentPoint = PointA.transform;
//            Flip();
//        }
//        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointA.transform)
//        {
//            currentPoint = PointB.transform;
//            Flip();
//        }
//    }
//    public void Flip()
//    {
//        IsFacingRight = !IsFacingRight;
//        Vector3 localscale = transform.localScale;
//        localscale.x *= -1f;
//        transform.localScale = localscale;
//    }

//}