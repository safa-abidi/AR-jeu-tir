using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeadScript : MonoBehaviour
{
    [SerializeField]
    ShootingTarget STarget;

    void Start()
    { 
        StartCoroutine("LoadMenu"); 
    }
    IEnumerator LoadMenu()
    {

        int score = STarget.Monscore;
        if (score > PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("score", score);
        }


        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("MenuPrincipal");
    }
}