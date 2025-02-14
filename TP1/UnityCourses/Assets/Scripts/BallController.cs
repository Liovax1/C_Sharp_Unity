using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    public Transform spawnPoint;  // Point de réapparition

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (spawnPoint == null)
        {
            Debug.LogError("Le spawnPoint n'est pas défini dans l'Inspector !");
        }

        Respawn(); // S'assure que la balle démarre au bon endroit
    }

    public void Respawn()
    {
        if (spawnPoint == null) return;

        // Réinitialise la position de la balle
        transform.position = spawnPoint.position;

        // Réinitialise la vélocité pour éviter que la balle garde son élan d'avant la mort
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // Active la balle si elle a été désactivée
        gameObject.SetActive(true);
    }
}
