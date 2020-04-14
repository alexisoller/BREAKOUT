using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedBlock : MonoBehaviour{

    /*
     class to controll the enemy red
    */
    public GameObject block;
    public GameObject particles;
    public AudioClip audio;
    private int randomDrop;

    void Start(){
        LevelManager.numInitialBlocks++;
    }
    void Update(){
    }

    void OnCollisionEnter(Collision collision) {

        GameObject firework = Instantiate(particles, this.transform.position, Quaternion.identity);
        firework.GetComponent<ParticleSystem>().Play();

        randomDrop = Random.Range(1, 20);//possibilities to drop a live when the enemy explote

        if (randomDrop==19) {
            GameObject bulletInstance = Instantiate(block, this.transform.position, Quaternion.identity);
            bulletInstance.GetComponent<Rigidbody>().AddForce(0.0f, 0.0f, -1.5f, ForceMode.Impulse);
        }
        
        AudioSource.PlayClipAtPoint(audio, this.gameObject.transform.position);

        Destroy(firework,6);//particles

        Destroy(gameObject);
        LevelManager.numInitialBlocks--;
    }

    

}
