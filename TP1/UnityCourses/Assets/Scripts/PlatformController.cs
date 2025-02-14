using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float rotationSpeed = 30f; // Vitesse de rotation

    private Transform platformParent; // Référence à l'objet parent contenant la plateforme et les murs

    void Start()
    {
        platformParent = transform;  // Le script est attaché à l'objet parent
    }

    void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;

        if (Input.GetKey(KeyCode.D)) horizontal = -1; // Déplacement à gauche
        if (Input.GetKey(KeyCode.A)) horizontal = 1;  // Déplacement à droite
        if (Input.GetKey(KeyCode.W)) vertical = 1;   // Déplacement en avant
        if (Input.GetKey(KeyCode.S)) vertical = -1;  // Déplacement en arrière

        // Appliquer la rotation au parent (plateforme + murs)
        if (horizontal != 0f || vertical != 0f)
        {
            // Calcul de la rotation en fonction des entrées
            Vector3 rotation = new Vector3(vertical, 0, horizontal) * rotationSpeed * Time.deltaTime;

            // Appliquer la rotation au parent
            platformParent.Rotate(rotation, Space.World);
        }
    }
}
