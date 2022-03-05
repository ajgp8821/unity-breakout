using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsBall : MonoBehaviour {

    [SerializeField]
    AudioSource ballBounce;
    [SerializeField]
    AudioSource point;
    [SerializeField]
    AudioSource loseLive;

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("collision " + collision.gameObject.tag);

        if (collision.gameObject.CompareTag("brick")) {
            point.Play();
        }
        else if (collision.gameObject.CompareTag("bar") || collision.gameObject.CompareTag("column")) {
            ballBounce.Play();
        }
        else if (collision.gameObject.CompareTag("ground")) {
            loseLive.Play();
        }
    }
}
