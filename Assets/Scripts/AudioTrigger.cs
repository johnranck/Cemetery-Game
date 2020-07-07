using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    int indexNumber = 0;
    GameObject player;
    public GameObject trigger;
    GameObject musicManager; 
    public AudioSource audioClip; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            trigger.SetActive(true);
            audioClip.Play();
            Destroy(gameObject);

            Debug.Log("hittt");


        }
    }

}
