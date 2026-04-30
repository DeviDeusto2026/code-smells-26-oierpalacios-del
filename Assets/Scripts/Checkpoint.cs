using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Checkpoint");
        }
    }

}
