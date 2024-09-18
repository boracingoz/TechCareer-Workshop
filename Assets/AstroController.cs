using UnityEngine;

public class AstroController : MonoBehaviour
{
    public float speed = 5f; // Karakterin sabit h�z�
    public float rotationSpeed = 100f; // Karakterin d�n�� h�z�
    public GameObject rock; // Takip eden ta� nesnesi

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // �leri hareket
        rb.velocity = transform.up * speed;

        // D�n�� hareketleri
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.angularVelocity = rotationSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.angularVelocity = -rotationSpeed;
        }
        else
        {
            rb.angularVelocity = 0;
        }

        // Ta��n konumunu g�ncelle (karakteri takip etmesi i�in)
        rock.transform.position = transform.position;
    }
}