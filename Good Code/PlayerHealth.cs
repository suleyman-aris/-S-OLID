using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float health = 100f;
    void Damage(int damage)
    {
        health -= damage;
    }

    void HealthPlus()
    {
        health += 10;
    }
}
public class Collection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("HealthKit"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.HealthPlus();
            }
            Destroy(other.gameObject);
        }
    }
}
