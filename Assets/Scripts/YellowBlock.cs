using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowBlock : MonoBehaviour{
    TextMesh count_live;
    public AudioClip audio;
    public GameObject particles;
    private int touches = 2;
    void Start(){
       
        count_live = this.GetComponentInChildren<TextMesh>();
        count_live.text = touches.ToString();
        LevelManager.numInitialBlocks++;
    }
    void Update(){
    }

    void OnCollisionEnter(Collision collision)  {
        touches--;
        count_live.text = touches.ToString();

        if (touches == 0){
            GameObject firework = Instantiate(particles, this.transform.position, Quaternion.identity);
            firework.GetComponent<ParticleSystem>().Play();
            AudioSource.PlayClipAtPoint(audio, this.gameObject.transform.position);
            Destroy(gameObject);
            LevelManager.numInitialBlocks--;
        }
    }
}