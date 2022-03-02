using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    [SerializeField]
    float intialSpeed = 600f;

    private Rigidbody rig;
    private Vector3 initialPosition;
    private bool isGame;
    private Transform bar;

    private void Awake() {
        rig = GetComponent<Rigidbody>();
        bar = GetComponentInParent<Transform>();
    }

    private void Start() {
        initialPosition = transform.position;
    }

    private void Update() {
        if (!isGame && Input.GetButtonDown("Fire1")) {
            isGame = true;
            transform.SetParent(null);
            rig.isKinematic = false;
            rig.AddForce(new Vector3(intialSpeed, intialSpeed, 0));
        }
    }

    public void Reset() {
        transform.position = initialPosition;
        transform.SetParent(bar);
        isGame = false;
        StopMotion();
    }

    public void StopMotion() {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }
}
