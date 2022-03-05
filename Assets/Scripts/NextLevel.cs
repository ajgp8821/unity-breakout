using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    [SerializeField]
    public string levelToLoad;
    [SerializeField]
    float delay;

    [ContextMenu("Activate Load")]
    public void ActivateLoad() {
        Invoke("LoadLevel", delay);
    }

    private void LoadLevel() {
        SceneManager.LoadScene(levelToLoad);
    }

    public bool IsLastLevel() {
        return levelToLoad == "Title";
    }

}
