using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    Scene m_Scene;
    string sceneName;

    private Canvas cv;
    float currenTime = 0f;
    float startingTime = 15f;


    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        cv = GameObject.Find("menu").GetComponent<Canvas>();
        cv.enabled = false;
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)){
            
            if (Time.timeScale == 0){
                Time.timeScale = 1;
                cv.enabled = false;
            }
            else{
                Time.timeScale = 0;
                cv.enabled = true;
            } 
        }

    }


    public void buttonResume()
    {
        Time.timeScale = 1;
        cv.enabled = false;
    }
    public void buttonRestart()
    {
        //LevelManager.numInitialBlocks = 0;
        Time.timeScale = 1;
        cv.enabled = false;
        SceneManager.LoadScene(sceneName);
 
    }


}
