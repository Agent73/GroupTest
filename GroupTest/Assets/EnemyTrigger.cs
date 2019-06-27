using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<EnemyAI>())
        {
            other.GetComponent<EnemyAI>().speed *= -1;
        }
        if (other.GetComponent<player2>())
        {
            other.GetComponent<Rigidbody>().velocity *= -1;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(transform.position, Vector3.one);

    }
   
}
