using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Vérifie si c'est la balle
        {
            other.transform.position = new Vector3(0, 10, 0); // Réinitialiser la position de la balle, ou tu peux la détruire avec Destroy(other.gameObject);
        }
    }
}
