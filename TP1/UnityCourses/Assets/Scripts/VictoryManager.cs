using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Pour manipuler l'UI classique, ou "TMPro" si tu utilises TextMeshPro.

public class VictoryManager : MonoBehaviour
{
    public GameObject victoryPanel; // Le panel qui contient le message et les boutons
    public Text victoryText; // Le texte pour afficher "Bravo !"
    public Button restartButton; // Le bouton de redémarrage
    public Button quitButton; // Le bouton de quitter

    void Start()
    {
        // Assure-toi que tout est caché au début
        victoryPanel.SetActive(false);
    }

    // Méthode pour afficher le message de victoire
    public void ShowVictoryMessage()
    {
        // Active le panel de victoire
        victoryPanel.SetActive(true);
        // Affiche le message de victoire
        victoryText.text = "Bravo ! Vous avez gagné !";
        // Active les boutons de redémarrage et quitter
        restartButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }

    // Méthode pour recommencer le jeu
    public void RestartGame()
    {
        // Recharge la scène actuelle (gameplay)
        SceneManager.LoadScene("GameScene");
    }

    // Méthode pour quitter le jeu
    public void QuitGame()
    {
        // Quitte l'application
        Application.Quit();
    }
}
