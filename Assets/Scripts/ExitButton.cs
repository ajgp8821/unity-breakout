using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour {

    [SerializeField]
    bool exit;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (exit) {
                // Debug.Log("Salir de juego");
                Application.Quit();
            }
            else {
                SceneManager.LoadScene("Title");
            }
        }
    }

    private void Exit() {
        /*if (UNITY_EDITOR)
            UnityEditor.EditorApplication.isPlaying = false;
        else
            Application.Quit();*/
    }
}
