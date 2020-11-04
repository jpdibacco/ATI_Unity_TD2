using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle : MonoBehaviour{
    public Vector3 deplacement;
    void FixedUpdate()
    {
        transform.Translate(Time.deltaTime*deplacement);
    }
}
