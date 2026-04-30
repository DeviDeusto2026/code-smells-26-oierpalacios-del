using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{

    public Transform shootOrigin;

    private void Update()
    {
    
        Debug.DrawRay(shootOrigin.position, shootOrigin.forward * 1000, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            
            if (Physics.Raycast(shootOrigin.position, shootOrigin.forward, out RaycastHit hit))
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
                {
                    Destroy(hit.collider.gameObject);
                }

                Debug.Log("Hit");
            }
            else
            {
                Debug.Log("Miss");
            }
        }
    }

}
