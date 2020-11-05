using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ZoneFin : MonoBehaviour{
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Balle"){
            SceneManager.LoadScene(0);
        }
    }
}
