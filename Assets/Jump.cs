using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public LayerMask layer;
    public bool isGrounded;
    public Rigidbody2D rb;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down,0.1f,layer);

        if (hit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded=false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity += new Vector2(0, 3f * jumpForce);
        }
    }
}
