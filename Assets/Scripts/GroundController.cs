using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {

    [SerializeField]
    LivesController lives;
    [SerializeField]
    AudioSource loseLive;

    private void OnTriggerEnter(Collider other) {
        // Debug.Log("Pelota toca suelo");
        lives.LoseLive();
        loseLive.Play();
    }
}
