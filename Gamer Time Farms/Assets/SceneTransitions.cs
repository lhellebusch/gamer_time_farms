using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public void toMenu(){
      SceneManager.LoadScene(0);
    }

    public void quitGame(){
      Application.Quit();
    }
}
