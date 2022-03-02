using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public static int score = 0;

    [SerializeField]
    Text textScore;

    private void Start() {
        UpdateScoreCounter();
    }

    public void UpdateScore() {
        ScoreController.score++;
        UpdateScoreCounter();
    }

    private void UpdateScoreCounter() {
        textScore.text = "Score: " + ScoreController.score;
    }
}
