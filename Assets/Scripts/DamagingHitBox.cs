using UnityEngine;

public class DamagingHitBox : MonoBehaviour
{
    public float damage = 20f;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<HealthComponent>() != null)
        {
            collision.collider.GetComponent<HealthComponent>().TakeDamage(damage);
        }

        GameObject.Destroy(gameObject);
    }
}
