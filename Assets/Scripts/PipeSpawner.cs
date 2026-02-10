using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour
{

    public Birdy birdyScript;
    public GameObject Borular;
    public float height;
    public float time;
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    void Update()
    {
        
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!birdyScript.isDead)
        {
            Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);       
        }
    }
}
