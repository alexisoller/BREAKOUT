using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateGO_Menu : MonoBehaviour{
    float accelx, accely, accelz = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    void Update()
    {
        accelx = 0;
        accely = 70;
        accelz = 0;
        transform.Rotate(accelx * Time.deltaTime, accely * Time.deltaTime, accelz * Time.deltaTime);
    }
}
