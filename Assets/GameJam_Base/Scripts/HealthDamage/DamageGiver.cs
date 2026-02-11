using UnityEngine;

public class DamageGiver : MonoBehaviour
{
    public float damage = 1f;
    public LayerMask targetLayers;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (((1 << other.gameObject.layer) & targetLayers) == 0)
            return;

        if (other.TryGetComponent(out Health health))
        {
            health.TakeDamage(damage);
        }
    }
}
