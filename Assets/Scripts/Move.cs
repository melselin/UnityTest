using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 14);   
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.fixedDeltaTime;
    }
}
