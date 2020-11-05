using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Balle : MonoBehaviour{
    public Vector3 deplacement;
    public int nbrBriques;
    public GameObject prefabDebris;
    public float sidePower = 2f;
    void FixedUpdate(){
        transform.Translate(Time.deltaTime*deplacement);
    }
    void OnCollisionEnter(Collision collision) {
        deplacement = Vector3.Reflect(deplacement,collision.contacts[0].normal);
        if(collision.gameObject.tag == "Brique"){
            Destroy(collision.gameObject);
            nbrBriques--;
            Instantiate(prefabDebris,collision.transform.position,Quaternion.identity);
        }
        if (nbrBriques == 0){
            SceneManager.LoadScene("Victory");
        }
        if(collision.gameObject.tag == "Raquette"){
            // let's check where it collides:
            // print("First point that collided: " + collision.contacts[0].point.x);
            // now we can do something:
            if(collision.contacts[0].point.x <= -1.4 || collision.contacts[0].point.x <= 1.4){
                //print("kick the ball !!!");
                // we are going to put inside variable for the moment....
                transform.Translate(Time.deltaTime* deplacement * sidePower);
            }
        }
    }
}
