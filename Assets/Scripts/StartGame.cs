using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    private void Update() {
        if (Input.GetButtonDown("Fire1")) {
            LivesController.lives = 3;
            ScoreController.score = 0;
            SceneManager.LoadScene("Level01");
        }
    }
}
