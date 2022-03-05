using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public static int score = 0;

    [SerializeField]
    Text textScore;
    [SerializeField]
    BarController bar;
    [SerializeField]
    GameObject levelCompleted;
    [SerializeField]
    GameObject gameCompleted;
    [SerializeField]
    NextLevel nextLevel;
    [SerializeField]
    BallController ball;
    [SerializeField]
    Transform bricksContainer;
    [SerializeField]
    GameOverSound gameOverSound;

    private void Start() {
        UpdateScoreCounter();
    }

    public void UpdateScore() {
        ScoreController.score++;
        UpdateScoreCounter();
    }

    private void UpdateScoreCounter() {
        textScore.text = "Score: " + ScoreController.score;

        if (bricksContainer.childCount <= 0) {
            ball.StopMotion();
            bar.enabled = false;

            if (nextLevel.IsLastLevel())
                gameCompleted.SetActive(true);
            else
                levelCompleted.SetActive(true);

            gameOverSound.LevelCompleted();

            nextLevel.ActivateLoad();
        }
    }
}
