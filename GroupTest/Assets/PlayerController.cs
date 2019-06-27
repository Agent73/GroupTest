using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = -5;
    public bool Rays = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newVel = new Vector2(0, 0);
        if (Input.GetKey("a"))
        {
            //left
            newVel.x = -speed;
        }
        if (Input.GetKey("s"))
        {
            //Down
            newVel.y = -speed;
        }
        if (Input.GetKey("d"))
        {
            //Right
            newVel.x = speed;
        }
        if (Rays)
        {
            float castdistance = transform.localScale.y / 2f + 0.1f;
            Debug.DrawRay(transform.position, Vector3.down, Color.red, castdistance);
            Debug.DrawRay(transform.position + Vector3.left * transform.localScale.x / 2f, Vector3.down, Color.red, castdistance);
            Debug.DrawRay(transform.position + Vector3.right * transform.localScale.x / 2f, Vector3.down, Color.red, castdistance);
            bool onGround =
                Physics.Raycast(transform.position, Vector3.down, castdistance)
                || Physics.Raycast(transform.position + Vector3.left * transform.localScale.x / 2f, Vector3.down, castdistance)
                || Physics.Raycast(transform.position + Vector3.right * transform.localScale.x / 2f, Vector3.down, castdistance);
            if (Input.GetKey("w") && onGround)
            {
                //Up
                newVel.y = speed;
            }
        }
        if (newVel.x != 0 || newVel.y != 0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(newVel.x, newVel.y, 0);
        }

    }
}
