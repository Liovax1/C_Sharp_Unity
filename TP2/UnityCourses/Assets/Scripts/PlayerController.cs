using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 30f;  // Force du saut
    private Rigidbody rb;  // Référence au Rigidbody du joueur

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // On récupère le Rigidbody
    }

    void Update()
    {
        // Vérifie si le joueur appuie sur la touche "Jump" (espace)
        if (Input.GetButtonDown("Jump"))
        {
            // Vérifie si la capsule touche bien une plateforme
            if (IsGrounded())
            {
                Jump();  // Appelle la fonction de saut
            }
        }
    }

    void Jump()
    {
        // Applique une force de saut sur l'axe Y
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    bool IsGrounded()
    {
        // Utilise la taille du collider pour définir un rayon dynamique
        float capsuleHeight = GetComponent<Collider>().bounds.extents.y;
        return Physics.Raycast(transform.position, Vector3.down, capsuleHeight + 0.1f);
    }

}
