using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform")) // V�rifie si c'est une plateforme
        {
            Debug.Log("Le joueur est mort !");
            Die();
        }
    }

    void Die()
    {
        // Recharge la sc�ne (game over)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
