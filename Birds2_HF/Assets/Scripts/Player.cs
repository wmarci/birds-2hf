using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private Vector2 targetPos;
    public float Yincrement; // vertikális irányban lépkedés
    public float speed;
    public float maxHeight; // meddig mehet max a madár
    public float minHeight; // meddig mehet min a madár

    [SerializeField]
    public int health;

    public GameObject effect;
    public Animator camAnim;

    public Image Heart1, Heart2, Heart3;

    public GameObject gameOver;

    void Start () {

        health = 3;
        Heart3.gameObject.SetActive(true);
    }
	
	
	void Update () {

        if (health == 3)
        {
            Heart1.gameObject.SetActive(false);
            Heart2.gameObject.SetActive(false);
            Heart3.gameObject.SetActive(true);
        }
        else if (health == 2)
        {

            Heart1.gameObject.SetActive(false);
            Heart2.gameObject.SetActive(true);
            Heart3.gameObject.SetActive(false);

        }
        else if (health == 1)
        {

            Heart1.gameObject.SetActive(true);
            Heart2.gameObject.SetActive(false);
            Heart3.gameObject.SetActive(false);

        }


        if (health <= 0) {

            gameOver.SetActive(true);
            Destroy(gameObject);

        }


        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime); // átmenet

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight){ // felfelé bill megnyomása
            camAnim.SetTrigger("shake"); // shake animáció felfelé mozgásnál
            Instantiate(effect, transform.position, Quaternion.identity); // effekt bejátszás felfelé mozgásnál
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);

            transform.position = targetPos;


        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) { // lefelé bill megnyomása

            camAnim.SetTrigger("shake"); // shake animáció lefelé mozgásnál
            Instantiate(effect, transform.position, Quaternion.identity); // effekt bejátszás lefelé mozgásnál
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
            transform.position = targetPos;

        }
   


	}
}
