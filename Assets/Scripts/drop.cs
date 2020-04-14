using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour{
    
    //class to 'kill 'the drop (live)
    void Start(){
      
    }

   
    void Update(){
        
    }
    

    void OnTriggerEnter(Collider other) { 
        if (other.gameObject.tag == "Die"){

            Destroy(gameObject);
        }
    }

   
}
