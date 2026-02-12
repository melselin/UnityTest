using UnityEngine;

public class CameraFollowSimple2D : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 0, -10);

    void LateUpdate()
    {
        if (!target) return;

        transform.position = target.position + offset;
    }
}
