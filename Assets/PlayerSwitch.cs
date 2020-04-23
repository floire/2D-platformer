using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public int count = 1;
    public GameObject mainPlayer;
    public GameObject spiritPlayer;



    void Start()
    {
        mainPlayer.GetComponent<PlayerController>().enabled = true;
        spiritPlayer.GetComponent<PlayerController>().enabled = false;
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (count == 1)
            {
                mainPlayer.GetComponent<PlayerController>().enabled = false;
                spiritPlayer.GetComponent<PlayerController>().enabled = true;
                count = 0;


            }
            else
            {
                mainPlayer.GetComponent<PlayerController>().enabled = true;
                spiritPlayer.GetComponent<PlayerController>().enabled = false;
                count = 1;
            }
        }
    }
}