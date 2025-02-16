using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed = 5f; // Vitesse de d�placement

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // D�truire la plateforme quand elle sort de l'�cran
        if (transform.position.x < -40)
        {
            GameManager.instance.AddScore(); // Ajouter un point au score
            Destroy(gameObject);
        }
    }

}
