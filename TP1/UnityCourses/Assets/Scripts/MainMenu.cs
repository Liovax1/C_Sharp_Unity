using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Charge la scène de jeu (assurez-vous que la scène du jeu est ajoutée dans Build Settings)
        SceneManager.LoadScene("GameScene"); // Remplace "GameScene" par le nom de ta scène de jeu
    }

    public void QuitGame()
    {
        // Quitte le jeu
        Application.Quit();
    }
}
