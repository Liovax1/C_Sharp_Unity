using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuUI; // Référence au panel du menu pause
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        pauseMenuUI.SetActive(true); // Affiche le menu pause
        Time.timeScale = 0f; // Met le jeu en pause
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenuUI.SetActive(false); // Cache le menu pause
        Time.timeScale = 1f; // Remet le jeu en marche
    }

    public void QuitGame()
    {
        Time.timeScale = 1f; // S'assurer que le jeu ne reste pas bloqué en pause
        Application.Quit();
    }
}
