using UnityEngine;

public class LerpMovement : MonoBehaviour
{
    public float minX = -6.28f; // Minimum x de�eri
    public float maxX = 8.21f;  // Maksimum x de�eri
    public float speed = 2.0f;  // Hareket h�z�

    private float time = 0.0f;
    private bool movingToMax = true; // minX'den maxX'e mi hareket ediliyor?

    void Update()
    {
        // Zaman� g�ncelle
        time += Time.deltaTime * speed;

        if (movingToMax)
        {
            // minX'den maxX'e do�ru hareket et
            float x = Mathf.Lerp(minX, maxX, time);
            transform.position = new Vector3(x, transform.position.y, transform.position.z);

            // maxX'e ula��ld�ysa geri d�n
            if (time >= 1.0f)
            {
                time = 0.0f;
                movingToMax = false;
            }
        }
        else
        {
            // maxX'den minX'e do�ru hareket et
            float x = Mathf.Lerp(maxX, minX, time);
            transform.position = new Vector3(x, transform.position.y, transform.position.z);

            // minX'e ula��ld�ysa tekrar maxX'e git
            if (time >= 1.0f)
            {
                time = 0.0f;
                movingToMax = true;
            }
        }
    }
}
