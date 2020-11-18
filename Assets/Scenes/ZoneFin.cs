using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ZoneFin : MonoBehaviour{
    public GameObject prefabBalle;
    public int lives;
    AudioSource audioData;
    void OnTriggerEnter(Collider other) {
        audioData = GetComponent<AudioSource>();
        if(other.gameObject.tag == "Balle"){
            //SceneManager.LoadScene(0);
            // GamePlay version 2:
            // .. this is weird:
            //other.gameObject.transform.position = new Vector3(0,-5,-25);
            //let's destroy it and create a new one:
            Destroy(other.gameObject);
            // ok this works... but the ball continues bouncing... and the racket is whatever last position X axis...
            Instantiate(prefabBalle,new Vector3(0,-5,-25),Quaternion.identity);
            lives--;
            audioData.Play(0);
            
        }
        if(lives == 0){
            SceneManager.LoadScene(0);
        }
    }
}
