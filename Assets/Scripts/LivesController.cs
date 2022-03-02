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

    public static int lives = 3;

    private void Start() {
        UpdateLiveCounter();
    }

    public void LoseLive() {
        LivesController.lives--;
        UpdateLiveCounter();
        // Reset Bar & Ball
        bar.Reset();
        ball.Reset();
    }

    private void UpdateLiveCounter() {
        textLives.text = "Lives: " + LivesController.lives;
    }

}
