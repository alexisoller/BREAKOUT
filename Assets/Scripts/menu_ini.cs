using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_ini : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void level1(){
        SceneManager.LoadScene("level1");
    }

    public void level2(){
        SceneManager.LoadScene("level2");
    }
    public void level3(){
        SceneManager.LoadScene("level3");
    }
    public void level4()
    {
        SceneManager.LoadScene("level4");
    }
    
    public void tutorial()
    {
        SceneManager.LoadScene("tutorial");
    }

    public void Restart(){
        SceneManager.LoadScene("menu_ini");
    }
}
