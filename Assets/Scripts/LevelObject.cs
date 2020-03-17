using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class LevelManager {
    public static int numInitialBlocks = 0;
}

public class LevelObject : MonoBehaviour {
    // Use this for initialization
    public Text number_of_enemies;
    public Text level_name;
    public Canvas cv;
    Scene m_Scene;
    string sceneName;
    void Start() {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        level_name.text=sceneName;

        LevelManager.numInitialBlocks = 0;
        //cv = GameObject.Find("menu").GetComponent<Canvas>();
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            cv.enabled = !cv.enabled;
        }
        number_of_enemies.text = LevelManager.numInitialBlocks.ToString();
        if (LevelManager.numInitialBlocks == 0) {
            SceneManager.LoadScene("Goal");
        }
       
            //Application.LoadLevel(Application.loadedLevel);
    }
}
