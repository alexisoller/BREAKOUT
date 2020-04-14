using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDamping : MonoBehaviour{
    /*
     * class to follow the ball if we want( dont used on this game)
     */
    public GameObject target;
    public float damping = 0.5f;
    Vector3 offset;

    void Start(){
        offset = transform.position - target.transform.position;
    }

    
    void LateUpdate(){
        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
        transform.position = position;


    }
}
