using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesController : MonoBehaviour {

    [SerializeField]
    Text textLives;
    [SerializeField]
    BarController bar;
    [SerializeField]
    BallController ball;
    [SerializeField]
    GameObject gameOver;
    [SerializeField]
    NextLevel nextLevel;

    public static int lives = 1;

    private void Start() {
        UpdateLiveCounter();
    }

    public void LoseLive() {
        if (lives <= 0) return;

        LivesController.lives--;
        UpdateLiveCounter();

        if (lives <= 0) {
            // GameOver
            gameOver.SetActive(true);
            ball.StopMotion();
            // Debug.Log("bar.enabled antes " + bar.enabled);
            bar.enabled = false;
            // Debug.Log("bar.enabled despues " + bar.enabled);
            nextLevel.levelToLoad = "Title";
            nextLevel.ActivateLoad();
        }
        else {
            // Reset Bar & Ball
            bar.Reset();
            ball.Reset();
        }
    }

    private void UpdateLiveCounter() {
        textLives.text = "Lives: " + LivesController.lives;
    }

}
