using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public int count = 1;
    public GameObject mainPlayer;
    public GameObject spiritPlayer;

    public CameraFollow _camerafollowScript;

    void Start()
    {
        mainPlayer.GetComponent<PlayerController>().enabled = true;
        spiritPlayer.GetComponent<SpiritController>().enabled = false;

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (count == 1)
            {
                mainPlayer.GetComponent<PlayerController>().enabled = false;
                spiritPlayer.GetComponent<SpiritController>().enabled = true;

                _camerafollowScript.mainFollow = spiritPlayer.transform;

                count = 0;

            }
            else
            {
                mainPlayer.GetComponent<PlayerController>().enabled = true;
                spiritPlayer.GetComponent<SpiritController>().enabled = false;

                _camerafollowScript.mainFollow = mainPlayer.transform;

                count = 1;
            }
        }
    }
}