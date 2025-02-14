using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform platform; // La plateforme à suivre
    public Transform player;   // La balle à suivre
    public Vector3 offset = new Vector3(0, 5, -10); // Décalage position caméra
    public float sensitivity = 2f; // Sensibilité de la souris

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
