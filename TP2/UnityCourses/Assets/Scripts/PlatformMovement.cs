using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed = 5f; // Vitesse de déplacement

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Détruire la plateforme quand elle sort de l'écran
        if (transform.position.x < -40)
        {
            GameManager.instance.AddScore(); // Ajouter un point au score
            Destroy(gameObject);
        }
    }

}
