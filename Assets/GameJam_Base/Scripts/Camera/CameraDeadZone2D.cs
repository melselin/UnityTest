using UnityEngine;

public class CameraDeadZone2D : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 0, -10);

    [Header("Dead Zone Size")]
    public Vector2 deadZone = new Vector2(2f, 1.5f);

    void LateUpdate()
    {
        if (!target) return;

        Vector3 cam = transform.position;
        Vector3 t = target.position + offset;

        float dx = t.x - cam.x;
        float dy = t.y - cam.y;

        if (Mathf.Abs(dx) > deadZone.x)
            cam.x += dx - Mathf.Sign(dx) * deadZone.x;

        if (Mathf.Abs(dy) > deadZone.y)
            cam.y += dy - Mathf.Sign(dy) * deadZone.y;

        transform.position = cam;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, deadZone * 2);
    }
}
