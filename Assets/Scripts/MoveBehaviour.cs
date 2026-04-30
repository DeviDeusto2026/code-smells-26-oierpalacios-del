using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{

    private Rigidbody playerRigidbody;

    public float moveSpeed;
    public float rotateSpeed;
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            // Move forward
            playerRigidbody.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime * 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Move backward
            playerRigidbody.MovePosition(transform.position - transform.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Rotate left
            playerRigidbody.MoveRotation(Quaternion.Euler(transform.localRotation.eulerAngles - Vector3.up * rotateSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Rotate right
            playerRigidbody.MoveRotation(Quaternion.Euler(transform.localRotation.eulerAngles + Vector3.up * rotateSpeed * Time.deltaTime * 1));
        }
    }

}