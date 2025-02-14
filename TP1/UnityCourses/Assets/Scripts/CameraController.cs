using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform platform; // La plateforme � suivre
    public Transform player;   // La balle � suivre
    public Vector3 offset = new Vector3(0, 5, -10); // D�calage position cam�ra
    public float sensitivity = 2f; // Sensibilit� de la souris

    private float rotationY = 0f;

    void Update()
    {
        // Rotation avec la souris
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        rotationY += mouseX;

        // Calculer la position moyenne entre la plateforme et la balle
        Vector3 averagePosition = (platform.position + player.position) / 2;

        // Appliquer la rotation autour de la position moyenne (plateforme et balle)
        transform.position = averagePosition + Quaternion.Euler(0, rotationY, 0) * offset;

        // Regarder la position moyenne (plateforme et balle)
        transform.LookAt(averagePosition);
    }
}
