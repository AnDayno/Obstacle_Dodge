using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            projectile.SetActive(true);
        }
    }
}
