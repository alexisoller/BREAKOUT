using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowBlock : MonoBehaviour{
    TextMesh count_live;
    public AudioClip audio;
    public GameObject particles;
    public GameObject block;



    private int touches = 2;
    private int randomDrop;

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

            randomDrop = Random.Range(1, 20);

            if (randomDrop == 19)
            {
                GameObject bulletInstance = Instantiate(block, this.transform.position, Quaternion.identity);
                bulletInstance.GetComponent<Rigidbody>().AddForce(0.0f, 0.0f, -1.5f, ForceMode.Impulse);
            }

            AudioSource.PlayClipAtPoint(audio, this.gameObject.transform.position);
            Destroy(firework, 6);//destroy object after 6 seconds because its a particle sistem 
            Destroy(gameObject);
            LevelManager.numInitialBlocks--;
        }
    }
}