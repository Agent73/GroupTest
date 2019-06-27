using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(speed, rb.velocity.y, 0);
    }

    private void OnDrawGizmos()
    {
        if (rb)
            Gizmos.DrawLine(transform.position, transform.position + rb.velocity);
    }

}
