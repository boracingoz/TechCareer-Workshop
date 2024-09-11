using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronotMove : MonoBehaviour
{
    [SerializeField] int maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float hori = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hori, 0, 0) * maxSpeed * Time.deltaTime;
        float vert = Input.GetAxis("Vertical");
        transform.position += new Vector3(0,vert,0) * maxSpeed * Time.deltaTime;
        //Debug.Log("yatay");
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("Çarpýsþma gerçekleþti!");
    //}

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Elmasla temase geçildi!");
    }
}
