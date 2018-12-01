using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int damage = 1;
    public float speed;

    public GameObject effect; // csillagos effekt

    // public Animator camAnim;

    void Update()
    {

        transform.Translate(Vector2.left * speed * Time.deltaTime); // az ellenfél a madar felé haladjon


    }


    void OnTriggerEnter2D(Collider2D other) { 

        if (other.CompareTag("Player")) { // ütközés az ellenféllel

            // camAnim.SetTrigger("shake"); // ellenség megütésénél shake
            Instantiate(effect,transform.position, Quaternion.identity);

            other.GetComponent<Player>().health -= damage; // ütközés, miatt egy élet elvétele 
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
            

        }

        
    }
   


    void Start () {
		
	}
	
	
	
}
