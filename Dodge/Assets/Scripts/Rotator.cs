using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;
    // private float time;

    // void Start() {
    //     time = 0;
    // }
    
    void Update() {
        // time += Time.deltaTime;
        // if (time >= 1f/rotationSpeed) {
        //     transform.Rotate(0f, 1, 0f);
        //     time = 0;
        // }
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
