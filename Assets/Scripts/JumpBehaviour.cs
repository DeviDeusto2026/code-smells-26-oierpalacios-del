using UnityEngine;

public class JB : MonoBehaviour
{

    public Rigidbody playerRigidbody;
    private int jumpForce = 400;

    private int groundCollisions;
    string nombre = "Ground";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer(nombre))
        {
            groundCollisions++;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer(nombre))
        {
            groundCollisions--;
        }
    }

    void Update()
    {
        bool isGrounded = groundCollisions > 0;

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }

}