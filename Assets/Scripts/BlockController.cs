using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {

    [SerializeField]
    GameObject particleEffect;
    [SerializeField]
    ScoreController score;

    private void OnCollisionEnter(Collision collision) {
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        score.UpdateScore();
    }
}
