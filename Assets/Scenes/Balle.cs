using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Balle : MonoBehaviour{
    public Vector3 deplacement;
    public int nbrBriques;
    public GameObject prefabDebris;
    public float sidePower = 1.0f;
    private float speed = 1.0f;
    void FixedUpdate(){
        transform.Translate(Time.deltaTime*deplacement*speed);
    }
    void OnCollisionEnter(Collision collision) {
        deplacement = Vector3.Reflect(deplacement,collision.contacts[0].normal);
        if(collision.gameObject.tag == "Brique"){
            Destroy(collision.gameObject);
            nbrBriques--;
            speed+=0.03f;
            //Instantiate(prefabDebris,collision.transform.position,Quaternion.identity);
            for (int i = 0; i < 3; i++){
                Vector3 motion = new Vector3(Random.Range(-2.0f, 2.0f), 0, 0);
                Instantiate(prefabDebris, transform.position + motion * i, Quaternion.identity);
            }
        }
        Debug.Log(nbrBriques);
        if (nbrBriques == 0){
            SceneManager.LoadScene("Victory");
        }
        if(collision.gameObject.tag == "Raquette"){
            // let's check where it collides:
            print("First point that collided: " + collision.contacts[0].point.x);
            // now we can do something:
            if(collision.contacts[0].point.x <= -1.4 || collision.contacts[0].point.x <= 1.4){
                print("kick the ball !!!");
                // we translate again?
                transform.Translate(Time.deltaTime* deplacement);
            }
        }
    }
}
