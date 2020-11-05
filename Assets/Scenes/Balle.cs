using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Balle : MonoBehaviour{
    public Vector3 deplacement;
    public int nbrBriques;
    void FixedUpdate(){
        transform.Translate(Time.deltaTime*deplacement);
    }
    void OnCollisionEnter(Collision collision) {
        deplacement = Vector3.Reflect(deplacement,collision.contacts[0].normal);
        if(collision.gameObject.tag == "Brique"){
            Destroy(collision.gameObject);
            nbrBriques--;
        }
        if (nbrBriques == 0){
            SceneManager.LoadScene("Victory");
        }
    }
}
