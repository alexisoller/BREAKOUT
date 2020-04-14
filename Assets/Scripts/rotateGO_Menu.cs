using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateGO_Menu : MonoBehaviour{

    /*
     class to control rotation of enemies on tutorial screen
    */
    float accelx, accely, accelz = 0;
   
    void Start(){

    }

    void Update() {
        accelx = 0;
        accely = 70;
        accelz = 0;
        transform.Rotate(accelx * Time.deltaTime, accely * Time.deltaTime, accelz * Time.deltaTime);
    }
}
