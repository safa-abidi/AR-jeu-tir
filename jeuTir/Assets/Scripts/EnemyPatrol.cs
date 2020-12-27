using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    float speed = 0f;

    void Start()
    {
        speed = Random.Range(5f, 10f); //nzid na9es f speed
    }

    void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
}
