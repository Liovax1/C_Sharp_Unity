using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Pour manipuler l'UI classique, ou "TMPro" si tu utilises TextMeshPro.

public class VictoryManager : MonoBehaviour
{
    public GameObject victoryPanel; // Le panel qui contient le message et les boutons
    public Text victoryText; // Le texte pour afficher "Bravo !"
    public Button restartButton; // Le bouton de red�marrage
    public Button quitButton; // Le bouton de quitter

    void Start()
    {
        // Assure-toi que tout est cach� au d�but
        victoryPanel.SetActive(false);
    }

    // M�thode pour afficher le message de victoire
    public void ShowVictoryMessage()
    {
        // Active le panel de victoire
        victoryPanel.SetActive(true);
        // Affiche le message de victoire
        victoryText.text = "Bravo ! Vous avez gagn� !";
        // Active les boutons de red�marrage et quitter
        restartButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }

    // M�thode pour recommencer le jeu
    public void RestartGame()
    {
        // Recharge la sc�ne actuelle (gameplay)
        SceneManager.LoadScene("GameScene");
    }

    // M�thode pour quitter le jeu
    public void QuitGame()
    {
        // Quitte l'application
        Application.Quit();
    }
}
