using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public static int balance = 5;
    public static int red_ct = 0;
    public static int orange_ct = 0;
    public static int yellow_ct = 0;
    public static int green_ct = 0;
    public static int blue_ct = 0;
    public static int indigo_ct = 0;
    public static int purple_ct = 0;
    public static int white_ct = 0;
    public static int rgb_ct = 0;

    public Text balText;
    public Text redBal;
    public Text orangeBal;
    public Text yellowBal;
    public Text greenBal;
    public Text blueBal;
    public Text indigoBal;
    public Text purpleBal;
    public Text whiteBal;

    public Button redButton;
    public Button orangeButton;
    public Button yellowButton;
    public Button greenButton;
    public Button blueButton;
    public Button indigoButton;
    public Button purpleButton;
    public Button whiteButton;

    public static int redGrowth = 0;
    public static int orangeGrowth = 0;
    public static int yellowGrowth = 0;
    public static int greenGrowth = 0;
    public static int blueGrowth = 0;
    public static int indigoGrowth = 0;
    public static int purpleGrowth = 0;
    public static int whiteGrowth = 0;

    public Sprite blank;

    public Sprite red1;
    public Sprite red2;
    public Sprite red3;

    public Sprite orange1;
    public Sprite orange2;
    public Sprite orange3;

    public Sprite yellow1;
    public Sprite yellow2;
    public Sprite yellow3;

    public Sprite green1;
    public Sprite green2;
    public Sprite green3;

    public Sprite blue1;
    public Sprite blue2;
    public Sprite blue3;

    public Sprite indigo1;
    public Sprite indigo2;
    public Sprite indigo3;

    public Sprite purple1;
    public Sprite purple2;
    public Sprite purple3;

    public Sprite white1;
    public Sprite white2;
    public Sprite white3;


    void Start(){
      redButton.GetComponent<Image>().sprite = blank;
      orangeButton.GetComponent<Image>().sprite = blank;
      yellowButton.GetComponent<Image>().sprite = blank;
      greenButton.GetComponent<Image>().sprite = blank;
      blueButton.GetComponent<Image>().sprite = blank;
      indigoButton.GetComponent<Image>().sprite = blank;
      purpleButton.GetComponent<Image>().sprite = blank;
      whiteButton.GetComponent<Image>().sprite = blank;


    }

    void Update(){
      balText.text = "Balance: ₿" + balance.ToString();
      redBal.text = red_ct.ToString();
      orangeBal.text = orange_ct.ToString();
      yellowBal.text = yellow_ct.ToString();
      greenBal.text = green_ct.ToString();
      blueBal.text = blue_ct.ToString();
      indigoBal.text = indigo_ct.ToString();
      purpleBal.text = purple_ct.ToString();
      whiteBal.text = white_ct.ToString();
    }

    private void Awake(){
      if(instance == null){
        instance = this;
      }
      else {
        Destroy(this.gameObject);
      }
    }

    //buy functions
    public void buy_secret_door(){
      if(balance >=1000){
        balance -= 1000;
        SceneManager.LoadScene(4);
      }
    }

    public void buy_red(){
      if(balance >= 5){
        red_ct += 1;
        balance -= 5;
      }
    }

    public void buy_orange(){
      if(balance >= 10){
        orange_ct += 1;
        balance -= 10;
      }
    }

    public void buy_yellow(){
      if(balance >= 15){
        yellow_ct += 1;
        balance -= 15;
      }
    }

    public void buy_green(){
      if(balance >= 20){
        green_ct += 1;
        balance -= 20;
      }
    }

    public void buy_blue(){
      if(balance >= 30){
        blue_ct += 1;
        balance -= 30;
      }
    }

    public void buy_indigo(){
      if(balance >= 50){
        indigo_ct += 1;
        balance -= 50;
      }
    }

    public void buy_purple(){
      if(balance >= 100){
        purple_ct += 1;
        balance -= 100;
      }
    }

    public void buy_white(){
      if(balance >= 250){
        white_ct += 1;
        balance -= 250;
      }
    }

    //sell functions
    public void sell_red(){
      balance += 10;
    }

    public void sell_orange(){
      balance += 20;
    }

    public void sell_yellow(){
      balance += 30;
    }

    public void sell_green(){
      balance += 40;
    }

    public void sell_blue(){
      balance += 60;
    }

    public void sell_indigo(){
      balance += 100;
    }

    public void sell_purple(){
      balance += 200;
    }

    public void sell_white(){
      balance += 500;
    }

    //grow functions
    public void grow_red(){
      switch(redGrowth){
        case 0:
          if(red_ct >=1){
            red_ct -= 1;
            redGrowth += 1;
            redButton.GetComponent<Image>().sprite = red1;
          }
          break;

        case 1:
          redGrowth += 1;
          redButton.GetComponent<Image>().sprite = red2;
          break;

        case 2:
          redGrowth += 1;
          redButton.GetComponent<Image>().sprite = red3;
          break;

        case 3:
          sell_red();
          redGrowth = 0;
          redButton.GetComponent<Image>().sprite = blank;
          break;

      }
    }

    public void grow_orange(){
      switch(orangeGrowth){
        case 0:
          if(orange_ct >=1){
            orange_ct -= 1;
            orangeGrowth += 1;
            orangeButton.GetComponent<Image>().sprite = orange1;
          }
          break;

        case 1:
          orangeGrowth += 1;
          orangeButton.GetComponent<Image>().sprite = orange2;
          break;

        case 2:
          orangeGrowth += 1;
          orangeButton.GetComponent<Image>().sprite = orange3;
          break;

        case 3:
          sell_orange();
          orangeGrowth = 0;
          orangeButton.GetComponent<Image>().sprite = blank;
          break;

      }
    }

    public void grow_yellow(){
      switch(yellowGrowth){
        case 0:
          if(yellow_ct >=1){
            yellow_ct -= 1;
            yellowGrowth += 1;
            yellowButton.GetComponent<Image>().sprite = yellow1;
          }
          break;

        case 1:
          yellowGrowth += 1;
          yellowButton.GetComponent<Image>().sprite = yellow2;
          break;

        case 2:
          yellowGrowth += 1;
          yellowButton.GetComponent<Image>().sprite = yellow3;
          break;

        case 3:
          sell_yellow();
          yellowGrowth = 0;
          yellowButton.GetComponent<Image>().sprite = blank;
          break;

      }
    }

    public void grow_green(){
      switch(greenGrowth){
        case 0:
          if(green_ct >=1){
            green_ct -= 1;
            greenGrowth += 1;
            greenButton.GetComponent<Image>().sprite = green1;
          }
          break;

        case 1:
          greenGrowth += 1;
          greenButton.GetComponent<Image>().sprite = green2;
          break;

        case 2:
          greenGrowth += 1;
          greenButton.GetComponent<Image>().sprite = green3;
          break;

        case 3:
          sell_green();
          greenGrowth = 0;
          greenButton.GetComponent<Image>().sprite = blank;
          break;

      }
    }

    public void grow_blue(){
      switch(blueGrowth){
        case 0:
          if(blue_ct >=1){
            blue_ct -= 1;
            blueGrowth += 1;
            blueButton.GetComponent<Image>().sprite = blue1;
          }
          break;

        case 1:
          blueGrowth += 1;
          blueButton.GetComponent<Image>().sprite = blue2;
          break;

        case 2:
          blueGrowth += 1;
          blueButton.GetComponent<Image>().sprite = blue3;
          break;

        case 3:
          sell_blue();
          blueGrowth = 0;
          blueButton.GetComponent<Image>().sprite = blank;
          break;

      }
    }

    public void grow_indigo(){
      switch(indigoGrowth){
        case 0:
          if(indigo_ct >=1){
            indigo_ct -= 1;
            indigoGrowth += 1;
            indigoButton.GetComponent<Image>().sprite = indigo1;
          }
          break;

        case 1:
          indigoGrowth += 1;
          indigoButton.GetComponent<Image>().sprite = indigo2;
          break;

        case 2:
          indigoGrowth += 1;
          indigoButton.GetComponent<Image>().sprite = indigo3;
          break;

        case 3:
          sell_indigo();
          indigoGrowth = 0;
          indigoButton.GetComponent<Image>().sprite = blank;
          break;

      }
    }

    public void grow_purple(){
      switch(purpleGrowth){
        case 0:
          if(purple_ct >=1){
            purple_ct -= 1;
            purpleGrowth += 1;
            purpleButton.GetComponent<Image>().sprite = purple1;
          }
          break;

        case 1:
          purpleGrowth += 1;
          purpleButton.GetComponent<Image>().sprite = purple2;
          break;

        case 2:
          purpleGrowth += 1;
          purpleButton.GetComponent<Image>().sprite = purple3;
          break;

        case 3:
          sell_purple();
          purpleGrowth = 0;
          purpleButton.GetComponent<Image>().sprite = blank;
          break;

      }
    }

    public void grow_white(){
      switch(whiteGrowth){
        case 0:
          if(white_ct >=1){
            white_ct -= 1;
            whiteGrowth += 1;
            whiteButton.GetComponent<Image>().sprite = white1;
          }
          break;

        case 1:
          whiteGrowth += 1;
          whiteButton.GetComponent<Image>().sprite = white2;
          break;

        case 2:
          whiteGrowth += 1;
          whiteButton.GetComponent<Image>().sprite = white3;
          break;

        case 3:
          sell_white();
          whiteGrowth = 0;
          whiteButton.GetComponent<Image>().sprite = blank;
          break;

      }
    }
}
