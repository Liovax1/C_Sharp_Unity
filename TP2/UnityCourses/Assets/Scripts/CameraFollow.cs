using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Référence au joueur
    public Vector3 offset;   // Décalage fixe de la caméra

    void Start()
    {
        // La caméra est placée à une position fixe par rapport au joueur
        transform.position = player.position + offset;
    }

    void LateUpdate()
    {
        // On s'assure que la caméra ne bouge pas après son placement initial
        transform.position = player.position + offset;
    }
}
