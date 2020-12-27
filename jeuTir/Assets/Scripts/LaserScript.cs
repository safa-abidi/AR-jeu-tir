using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class LaserScript : MonoBehaviour
{
    [SerializeField]
    float delay = 0.2f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { 
            StartCoroutine(ShowLaser());
        }
    }
    IEnumerator ShowLaser()
    {
        GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(delay);
        GetComponent<Image>().enabled = false;
    }
}