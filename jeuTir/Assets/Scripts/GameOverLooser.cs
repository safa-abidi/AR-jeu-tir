using UnityEngine;
public class GameOverLooser : MonoBehaviour
{
    [SerializeField]
    GameObject GameOver;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("wini taswiraaa game overrrrrr :'((((((");

        GameOver.SetActive(true);
    }
}