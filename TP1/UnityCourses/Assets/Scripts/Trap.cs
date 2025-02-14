using UnityEngine;

public class Trap : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))  // Vérifie si c'est bien la balle
        {
            BallController ballController = other.GetComponent<BallController>();
            if (ballController != null)
            {
                ballController.Respawn();  // Fait réapparaître la balle
            }
        }
    }
}
