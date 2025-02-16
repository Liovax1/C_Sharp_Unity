using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Assure-toi que "GameScene" est bien le nom de ta sc�ne de jeu
    }

    public void QuitGame()
    {
        Application.Quit(); // Quitte l'application
    }
}
