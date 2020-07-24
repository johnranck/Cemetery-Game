using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkingStone : MonoBehaviour
{

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
                talkBox.SetActive(true);
                talkBox.GetComponent<InkTestingScript>().ShowPanels();
                talkBox.GetComponent<InkTestingScript>().refreshUI();
            }
            else
            {
                talkBox.SetActive(false);
                talkBox.GetComponent<InkTestingScript>().HidePanels();
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
            talkBox.GetComponent<InkTestingScript>().eraseUI();
            talkBox.GetComponent<InkTestingScript>().refreshStory();
            talkBox.GetComponent<InkTestingScript>().HidePanels(); 
        }
    }



    ///method to be used in "Fade" script
    public void Off()
    {
        talkBox.SetActive(false);
    }


}