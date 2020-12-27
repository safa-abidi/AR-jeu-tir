using UnityEngine;
public class ManagerEnnemysScript : MonoBehaviour
{
    [SerializeField] GameObject PrefabRobot;
    [SerializeField] float rayon = 10f, delay = 0.5f, rangeY = 5f;
    void Start()
    {
        InvokeRepeating("Generation", 0f, delay);
    } // Répéter la fonction Generation d’une manière régulière
     // Après N secondes (ici 0), avec une fréquence = delay
 void Generation()
    {
        int angle = Random.Range(1, 360);
        Vector3 pos = Vector3.zero;
        pos.x = transform.position.x + rayon * Mathf.Cos(angle);
        pos.z = transform.position.z + rayon * Mathf.Sin(angle);
        pos.y = Random.Range(-rangeY, rangeY);
        GameObject go = Instantiate(PrefabRobot, pos, Quaternion.identity);
    }
}