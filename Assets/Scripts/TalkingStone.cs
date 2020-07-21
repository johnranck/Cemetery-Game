using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkingStone : MonoBehaviour
{

    InkTestingScript inkTestingScript = new InkTestingScript();

    public GameObject talkBox;
    public bool playerInRange;


    void Start()
    {
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if (talkBox.activeInHierarchy)
            {
              //  talkBox.SetActive(true);
                FindObjectOfType<InkTestingScript>().refreshUI();

            }
            else
            {
                talkBox.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            FindObjectOfType<InkTestingScript>().eraseUI();
            FindObjectOfType<InkTestingScript>().storyReset(); 
        }
    }



    ///method to be used in "Fade" script
    public void Off()
    {
        talkBox.SetActive(false);
    }


}