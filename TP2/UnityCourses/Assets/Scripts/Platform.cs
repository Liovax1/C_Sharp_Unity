using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 50; // Vitesse de d�placement

    void Update()
    {
        // D�placement vers l'avant (axe Z n�gatif)
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // D�truire la plateforme quand elle sort de l'�cran
        if (transform.position.z < -50f) // Adapte cette valeur selon ta sc�ne
        {
            Destroy(gameObject);
        }
    }
}
