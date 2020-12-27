using UnityEngine;
using UnityEngine.UI;
public class ShootingTarget : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;

    RaycastHit hit;

    //for the score 
    [SerializeField] Text txtScore;
    private int score = 0;


    //for best score
    private void Start()
    {
       GameObject.Find("BestScore").GetComponent<Text>().text = "Best Score " + PlayerPrefs.GetInt("score").ToString();
    }


    public int Monscore{
        get { return score; }
        set { score = value; txtScore.text = "Score : " + score; }
    }
    void Update()
    {
        Vector2 center = new Vector2(Screen.width / 2, Screen.height / 2);
        Ray ray = Camera.main.ScreenPointToRay(center);
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) //Renvoie V si le rayon croise un collider
            {
                Destroy(hit.collider.transform.gameObject); } // Détruire l’ennemi

                //for the explotion
                GameObject Go = Instantiate(prefabExplosion, hit.transform.position, Quaternion.identity);             
                Destroy(Go, 3f);

                Monscore++;

        }
    }
}