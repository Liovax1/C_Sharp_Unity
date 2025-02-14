using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 200f;  // Force du saut
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
        // Vérifie si la capsule touche le sol (plateforme)
        return Physics.Raycast(transform.position, Vector3.down, 1f);
    }
}
