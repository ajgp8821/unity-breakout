using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    [SerializeField]
    float intialSpeed = 600f;

    private float maxSpeed = 18f;
    private float minSpeed = 4f;
    private Rigidbody rig;
    private Vector3 initialPosition;
    private bool isGame;
    private bool isfirstCollision;
    private Transform bar;

    private void Awake() {
        rig = GetComponent<Rigidbody>();
        bar = transform.parent.GetComponentInParent<Transform>();
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
        isfirstCollision = false;
    }

    private void OnCollisionEnter(Collision collision) {

        /*Debug.Log("isfirstCollision -> " + isfirstCollision);

        foreach (ContactPoint contact in collision.contacts) {
            print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
            // Visualize the contact point
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }*/
        if (collision.gameObject.CompareTag("bar") && isfirstCollision && collision.contacts[0].point.y == -7.5f && collision.gameObject.transform.position.x ==2) {
            float contactPoint = collision.contacts[0].point.x;
            Debug.Log("collision.contacts[0].point.y " + collision.contacts[0].point.y);
            float positionBarX = collision.gameObject.transform.position.x;
            float colliderPoint = contactPoint - positionBarX;

            float angle = colliderPoint * (Mathf.PI / 3);
            float speedX = maxSpeed * Mathf.Sin(angle);
            speedX = Mathf.Clamp(speedX, -maxSpeed, maxSpeed);
            
            float speedY = maxSpeed * Mathf.Cos(angle);
            speedY = Mathf.Abs(speedY);
            speedY = Mathf.Clamp(speedY, minSpeed, maxSpeed);

            rig.velocity = new Vector3(speedX, speedY, 0);
        }
        else {
            isfirstCollision = true;
        }
    }
}
