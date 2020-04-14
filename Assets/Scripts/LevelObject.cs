using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class LevelManager {
    //class to know how many enemies have the level
    public static int numInitialBlocks = 0;
}

public class LevelObject : MonoBehaviour {
    /*
     class to know info about the game,HUD
    */
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
      
    }
    
    void Update() {

        if (Input.GetKeyDown(KeyCode.Escape))        {
            cv.enabled = !cv.enabled;
        }
        number_of_enemies.text = LevelManager.numInitialBlocks.ToString();
        if (LevelManager.numInitialBlocks == 0) {
            SceneManager.LoadScene("Goal");
        }
    }
}
