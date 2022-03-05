using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSound : MonoBehaviour {

    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip completed;
    [SerializeField]
    AudioClip gameOver;

    public void GameOver() {
        PlaySound(gameOver);
    }

    public void LevelCompleted() {
        PlaySound(completed);
    }

    private void PlaySound(AudioClip audioClip) {
        audioSource.clip = audioClip;
        audioSource.loop = false;
        audioSource.Play();
    }
}
