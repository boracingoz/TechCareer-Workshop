using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronotMove : MonoBehaviour
{
    [SerializeField] int maxSpeed;
    public int crystal;

    [SerializeField] int health = 100;
    [SerializeField] int maxHealth = 100;

    void Start()
    {

    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        float hori = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hori, 0, 0) * maxSpeed * Time.deltaTime;
        float vert = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vert, 0) * maxSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Crystal")
        {
            crystal++;
            if (health < maxHealth) 
            {
                health += 1;
                if (health > maxHealth) 
                {
                    health = maxHealth;
                }
            }
            Debug.Log("Kristal sayýsý: " + crystal + " Saðlýk: " + health);
            Destroy(collision.gameObject);
        }
        
        else if (collision.tag == "Spike")
        {
            if (health > 0) 
            {
                health -= 1; 
                if (health < 0) 
                {
                    health = 0;
                }
            }
            Debug.Log("Düþmanla çarpýþtý! Saðlýk: " + health);
            Destroy(gameObject);
        }
    }
}
