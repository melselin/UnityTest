using UnityEngine;
using UnityEngine.InputSystem;

public class Birdy : MonoBehaviour
{

    public float velocity = 3f;
    public Rigidbody2D rigidbody2D;
    public bool isDead = false;
/**
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
*/
    // Update is called once per frame
    void Update()
    {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rigidbody2D.linearVelocity = Vector2.up * velocity;
        }
    }
}
