using UnityEngine;

public class ShakeOnCollision2D : MonoBehaviour
{
    public float multiplier = 1f; // scale strength per object

    void OnCollisionEnter2D(Collision2D collision)
    {
        TriggerShake();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        TriggerShake();
    }

    void TriggerShake()
    {
        if (Camera.main == null) return;

        CameraShake2D shake = Camera.main.GetComponent<CameraShake2D>();
        if (shake == null) return;

        shake.Shake();
    }
}
