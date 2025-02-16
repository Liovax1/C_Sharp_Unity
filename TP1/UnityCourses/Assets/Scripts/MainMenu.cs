using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Charge la sc�ne de jeu (assurez-vous que la sc�ne du jeu est ajout�e dans Build Settings)
        SceneManager.LoadScene("GameScene"); // Remplace "GameScene" par le nom de ta sc�ne de jeu
    }

    public void QuitGame()
    {
        // Quitte le jeu
        Application.Quit();
    }
}
