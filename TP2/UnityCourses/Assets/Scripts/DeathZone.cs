using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over !");
            // Ici, tu peux réinitialiser le jeu ou afficher un écran de fin
        }
    }
}
