using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingCylinder : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null) {
                playerController.Die();
            }
        }
    }
}
