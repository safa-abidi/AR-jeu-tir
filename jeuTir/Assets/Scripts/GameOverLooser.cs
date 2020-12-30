using UnityEngine;
public class GameOverLooser : MonoBehaviour
{
    [SerializeField]
    GameObject GameOver;
   
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("game overrrrrr :'((((((");
        GameOver.SetActive(true);
    }
}