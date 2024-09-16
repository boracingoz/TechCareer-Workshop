using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(Vector2.up*speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(Vector2.down*speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(Vector2.left * speed);
        }
    }
}
