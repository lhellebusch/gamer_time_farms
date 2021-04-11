using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public void toMenu(){
      SceneManager.LoadScene(0);
    }

    public void start(){
      SceneManager.LoadScene(1);
    }

    public void house(){
      SceneManager.LoadScene(2);
    }

    public void tutorial(){
      SceneManager.LoadScene(3);
    }

    public void secret(){
      SceneManager.LoadScene(4);
    }

    public void quitGame(){
      Application.Quit();
    }
}
