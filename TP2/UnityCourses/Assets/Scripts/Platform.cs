using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 50; // Vitesse de déplacement

    void Update()
    {
        // Déplacement vers l'avant (axe Z négatif)
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // Détruire la plateforme quand elle sort de l'écran
        if (transform.position.z < -50f) // Adapte cette valeur selon ta scène
        {
            Destroy(gameObject);
        }
    }
}
