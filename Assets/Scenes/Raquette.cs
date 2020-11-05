using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquette : MonoBehaviour{
    public float speed;
    public float clampX;
    void Update(){
        //float h = Input.GetAxisRaw("Horizontal");
        // new controller for the raquette (personally I preffer the keyboard...):
        float h =  Input.GetAxis("Mouse X");
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -clampX, clampX);
        transform.position = pos;
        transform.Translate(Vector3.right * h * speed * Time.deltaTime);
    }
}
