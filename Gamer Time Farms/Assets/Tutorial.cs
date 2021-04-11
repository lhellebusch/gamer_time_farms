using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Tutorial : MonoBehaviour
{
    public Sprite scene1;
    public Sprite scene2;
    public Sprite scene3;
    public Sprite scene4;
    public Sprite scene5;
    public Sprite scene6;
    public Sprite scene7;
    public Sprite scene8;
    public Sprite scene9;
    public Sprite scene10;
    public Sprite scene11;
    public Sprite scene12;
    public Sprite scene13;
    public Sprite scene14;
    public Sprite scene15;
    public Sprite scene16;
    public Sprite scene17;

    public AudioSource num1;
    public AudioSource num2;
    public AudioSource num3;
    public AudioSource num4;
    public AudioSource num5;
    public AudioSource num6;
    public AudioSource num7;
    public AudioSource num8;
    public AudioSource num9;
    public AudioSource num10;
    public AudioSource num11;
    public AudioSource num12;
    public AudioSource num13;
    public AudioSource num14;
    public AudioSource num15;


    public Button screen;
    public int scene = 1;


    // Start is called before the first frame update
    void Start()
    {
      screen.GetComponent<Image>().sprite = scene1;
      num1.Play();
    }

    public void clickThrough(){
      switch(scene){
        case(1):
          scene += 1;
          num2.Play();
          screen.GetComponent<Image>().sprite = scene2;
          break;

        case(2):
          scene += 1;
          num3.Play();
          screen.GetComponent<Image>().sprite = scene3;
          break;

        case(3):
          scene += 1;
          num4.Play();
          screen.GetComponent<Image>().sprite = scene4;
          break;

        case(4):
          scene += 1;
          num5.Play();
          screen.GetComponent<Image>().sprite = scene5;
          break;

        case(5):
          scene += 1;
          num6.Play();
          screen.GetComponent<Image>().sprite = scene6;
          break;

        case(6):
          scene += 1;
          num7.Play();
          screen.GetComponent<Image>().sprite = scene7;
          break;

        case(7):
          scene += 1;
          num8.Play();
          screen.GetComponent<Image>().sprite = scene8;
          break;

        case(8):
          scene += 1;
          num9.Play();
          screen.GetComponent<Image>().sprite = scene9;
          break;

        case(9):
          scene += 1;
          num10.Play();
          screen.GetComponent<Image>().sprite = scene10;
          break;

        case(10):
          scene += 1;
          num11.Play();
          screen.GetComponent<Image>().sprite = scene11;
          break;

        case(11):
          scene += 1;
          num12.Play();
          screen.GetComponent<Image>().sprite = scene12;
          break;

        case(12):
          scene += 1;
          screen.GetComponent<Image>().sprite = scene13;
          break;


        case(13):
          scene += 1;
          screen.GetComponent<Image>().sprite = scene14;
          break;

        case(14):
          scene += 1;
          num13.Play();
          screen.GetComponent<Image>().sprite = scene15;
          break;

        case(15):
          scene += 1;
          num14.Play();
          screen.GetComponent<Image>().sprite = scene16;
          break;

        case(16):
          scene += 1;
          screen.GetComponent<Image>().sprite = scene17;
          break;

        case(17):
          SceneManager.LoadScene(0);
          break;
      }
    }
}
