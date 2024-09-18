using UnityEngine;

public class AstroController : MonoBehaviour
{
    public float speed = 5f; // Karakterin sabit hýzý
    public float rotationSpeed = 100f; // Karakterin dönüþ hýzý
    public GameObject rock; // Takip eden taþ nesnesi

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Ýleri hareket
        rb.velocity = transform.up * speed;

        // Dönüþ hareketleri
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

        // Taþýn konumunu güncelle (karakteri takip etmesi için)
        rock.transform.position = transform.position;
    }
}