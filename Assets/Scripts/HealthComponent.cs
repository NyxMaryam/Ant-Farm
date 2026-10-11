using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
