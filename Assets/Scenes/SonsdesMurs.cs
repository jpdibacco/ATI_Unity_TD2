using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonsdesMurs : MonoBehaviour{
    public GameObject prefabBalle;
     AudioSource audioData;
      void OnCollisionEnter(Collision other) {
        audioData = GetComponent<AudioSource>();
        if(other.gameObject.tag == "Balle"){
             audioData.Play(0);
        }
    }
}
