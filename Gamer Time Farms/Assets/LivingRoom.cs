using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoom : MonoBehaviour
{
    private GameObject Page1;
    private GameObject Page2;
    private GameObject PauseScreen;
    private bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        PauseScreen = GameObject.Find("PauseCanvas");
        PauseScreen.GetComponent<Canvas>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(!paused){
            if(Input.GetKeyDown(KeyCode.Escape)){
              paused = true;
              PauseScreen.GetComponent<Canvas>().enabled = true;

            }
        } else if(Input.GetKeyDown(KeyCode.Escape)) {
            paused = false;
            PauseScreen.GetComponent<Canvas>().enabled = false;
        }

    }
}
