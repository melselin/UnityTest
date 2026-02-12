using UnityEngine;

public class CameraLookAhead2D : MonoBehaviour
{
    public Transform target;
    public Rigidbody2D targetRb;

    public float lookAheadDistance = 2f;
    public float smooth = 10f;

    Vector3 currentOffset;

    void LateUpdate()
    {
        if (!target || !targetRb) return;

        float dir = Mathf.Sign(targetRb.linearVelocity.x);

        Vector3 desiredOffset = new Vector3(dir * lookAheadDistance, 0, -10);

        currentOffset = Vector3.Lerp(currentOffset, desiredOffset, smooth * Time.deltaTime);

        transform.position = target.position + currentOffset;
    }
}
