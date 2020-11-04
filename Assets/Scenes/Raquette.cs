using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquette : MonoBehaviour{
    public float speed;
    void Update(){
        float h = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * h * speed * Time.deltaTime);
    }
}
