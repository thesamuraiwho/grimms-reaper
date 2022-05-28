using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float amount)
    {
        Debug.Log($"{name}");
        Debug.Log($"Current health: {health}");
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log($"{name} is dead");
        if (gameObject != null)
            Destroy(gameObject);
    }
}
