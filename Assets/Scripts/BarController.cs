using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour {

    [SerializeField]
    float speed = 20f;

    private Vector3 initialPosition;

    private void Start() {
        initialPosition = transform.position;
    }

    private void Update() {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (moveHorizontal * speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posX, -8, 8), transform.position.y, 0);
    }

    public void Reset() {
        transform.position = initialPosition;
    }
}
