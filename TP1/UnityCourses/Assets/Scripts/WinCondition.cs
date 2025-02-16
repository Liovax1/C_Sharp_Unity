using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public VictoryManager victoryManager; // R�f�rence au VictoryManager

    void OnTriggerEnter(Collider other)
    {
        // Si la balle touche l'objet de victoire
        if (other.CompareTag("Player"))
        {
            // Afficher le message de victoire
            victoryManager.ShowVictoryMessage();
        }
    }
}
