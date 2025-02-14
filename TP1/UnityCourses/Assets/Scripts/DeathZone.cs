using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // V�rifie si c'est la balle
        {
            other.transform.position = new Vector3(0, 10, 0); // R�initialiser la position de la balle, ou tu peux la d�truire avec Destroy(other.gameObject);
        }
    }
}
