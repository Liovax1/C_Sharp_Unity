using UnityEngine;
using TMPro; // Pour gérer le texte avec TextMeshPro

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Référence au texte du chronomètre
    private float elapsedTime = 0f; // Temps écoulé
    private bool isRunning = true; // Pour savoir si le chrono tourne

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseTimer();
        }

        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerDisplay();
        }
    }


    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void PauseTimer()
    {
        isRunning = !isRunning; // Met en pause ou reprend le chrono
    }
}
