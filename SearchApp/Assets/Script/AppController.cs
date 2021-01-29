using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppController : MonoBehaviour
{
    

    public InputField FindWordText;

    public GameObject resultText;

     string Google = "Google";
     string Hi5 = "Hi5";
     string Facebook = "Facebook";
     string MSN = "MSN";
     string Twitter = "Twitter";
    
    
    public void FindText()
    {
       

        if (FindWordText.text == "Google")
        {
            resultText.GetComponent<Text>().text = "[ "+ Google + " ] is found.";
        }

        else if (FindWordText.text == "google")
        {
            resultText.GetComponent<Text>().text = "[ " + Google + " ] is found.";
        }
        else if (FindWordText.text == "Hi5")
        {
            resultText.GetComponent<Text>().text = "[ " + Hi5 + " ] is found.";
        }

        else if (FindWordText.text == "hi5")
        {
            resultText.GetComponent<Text>().text = "[ " + Hi5 + " ] is found.";
        }

        else if (FindWordText.text == "Facebook")
        {
            resultText.GetComponent<Text>().text = "[ " + Facebook + " ] is found.";
        }
        else if (FindWordText.text == "facebook")
        {
            resultText.GetComponent<Text>().text = "[ " + Facebook + " ] is found.";
        }
        else if (FindWordText.text == "MSN")
        {
            resultText.GetComponent<Text>().text = "[ " + MSN + " ] is found.";
        }
        else if (FindWordText.text == "msn")
        {
            resultText.GetComponent<Text>().text = "[ " + MSN + " ] is found.";
        }
        else if (FindWordText.text == "Twitter")
        {
            resultText.GetComponent<Text>().text = "[ " + Twitter + " ] is found.";
        }
        else if (FindWordText.text == "twitter")
        {
            resultText.GetComponent<Text>().text = "[ " + Twitter + " ] is found.";
        }
        else
        {
            resultText.GetComponent<Text>().text = "Not found.";
        }
    }






}
