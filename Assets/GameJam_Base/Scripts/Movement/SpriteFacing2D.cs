using UnityEngine;

public class SpriteFacing2D : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform visualRoot;

    public float deadZone = 0.05f;

    public enum FacingMode
    {
        FlipX,      // mirror left/right (platformer)
        Rotate      // rotate toward movement (top-down)
    }

    public FacingMode mode = FacingMode.FlipX;

    void Reset()
    {
        rb = GetComponentInParent<Rigidbody2D>();
        visualRoot = transform;
    }

    void Update()
    {
        if (rb == null || visualRoot == null)
            return;

        Vector2 v = rb.linearVelocity;

        if (v.magnitude < deadZone)
            return;

        switch (mode)
        {
            case FacingMode.FlipX:
                {
                    Vector3 scale = visualRoot.localScale;
                    scale.x = Mathf.Abs(scale.x) * Mathf.Sign(v.x == 0 ? scale.x : v.x);
                    visualRoot.localScale = scale;
                    break;
                }

            case FacingMode.Rotate:
                {
                    float angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
                    visualRoot.rotation = Quaternion.Euler(0f, 0f, angle);
                    break;
                }
        }
    }
}
