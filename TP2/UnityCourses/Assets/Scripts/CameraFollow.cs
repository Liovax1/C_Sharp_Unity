using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // R�f�rence au joueur
    public Vector3 offset;   // D�calage fixe de la cam�ra

    void Start()
    {
        // La cam�ra est plac�e � une position fixe par rapport au joueur
        transform.position = player.position + offset;
    }

    void LateUpdate()
    {
        // On s'assure que la cam�ra ne bouge pas apr�s son placement initial
        transform.position = player.position + offset;
    }
}
