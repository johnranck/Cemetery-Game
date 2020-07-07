using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marjorieGrave : MonoBehaviour
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
                /*talkBox.SetActive(false); */
                FindObjectOfType<marjorieFade>().FadeMeOut();
            }
            else
            {
                talkBox.SetActive(true);
                FindObjectOfType<marjorieFade>().FadeMeIn();
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
            FindObjectOfType<marjorieFade>().FadeMeOut();
        }
    }



    ///method to be used in "Fade" script
    public void Off()
    {
        talkBox.SetActive(false);
    }


}