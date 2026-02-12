using UnityEngine;

public class CameraShake2D : MonoBehaviour
{

    //Does NOT work with CameraFollowSimple!!!
    public float duration = 0.2f;
    public float magnitude = 0.2f;

    float timer;
    Vector3 basePos;

    void Awake()
    {
        basePos = transform.localPosition;
    }

    void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
            transform.localPosition = basePos + (Vector3)Random.insideUnitCircle * magnitude;
        }
        else
        {
            transform.localPosition = basePos;
        }
    }

    public void Shake()
    {
        timer = duration;
    }
}
// to activate use this:
//Camera.main.GetComponent<CameraShake2D>().Shake();