using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private GameObject[] projectiles;

    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject projectile in projectiles)
        {
            if (projectile != null)
            {
                projectile.SetActive(true);
            }
        }
    }
}