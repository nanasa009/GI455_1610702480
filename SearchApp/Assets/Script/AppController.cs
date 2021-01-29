using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppController : MonoBehaviour
{
    

    public InputField FindWordText;

    public GameObject resultText;


     private string Google = "Google";
     private string Hi5 = "Hi5";
     private string Facebook = "Facebook";
     private string MSN = "MSN";
     private string Twitter = "Twitter";
    
    
    public void FindText()
    {


        if (FindWordText.text == "Google")
        {
            resultText.GetComponent<Text>().text = $"[ <color=green>" + (Google) + "</color> ] is found.";
        }

        else if (FindWordText.text == "google")
        {
            resultText.GetComponent<Text>().text = $"[ <color=green>" + (Google) + "</color> ] is found.";
        }
        else if (FindWordText.text == "Hi5")
        {
            resultText.GetComponent<Text>().text = $"[ <color=green>" + (Hi5) + "</color> ] is found.";
        }

        else if (FindWordText.text == "hi5")
        {
            resultText.GetComponent<Text>().text = $"[ <color=green>" + (Hi5) + "</color> ] is found.";
        }

        else if (FindWordText.text == "Facebook")
        {
            resultText.GetComponent<Text>().text = $"[ <color=green>" + (Facebook) + "</color> ] is found.";
        }
        else if (FindWordText.text == "facebook")
        {
            resultText.GetComponent<Text>().text = $"[ <color=green>" + (Facebook) + "</color> ] is found.";
        }
        else if (FindWordText.text == "MSN")
        {
            resultText.GetComponent<Text>().text = $"[ <color=green>" + (MSN) + "</color> ] is found.";
        }
        else if (FindWordText.text == "msn")
        {
            resultText.GetComponent<Text>().text = $"[ <color=green>" + (MSN) + "</color> ] is found.";
        }
        else if (FindWordText.text == "Twitter")
        {
            resultText.GetComponent<Text>().text = $"[ <color=green>" + (Twitter) + "</color> ] is found.";
        }
        else if (FindWordText.text == "twitter")
        {
            resultText.GetComponent<Text>().text = $"[ <color=green>" + (Twitter) + "</color> ] is found.";
        }
        else
        {
            resultText.GetComponent<Text>().text = $"<color=red>" + FindWordText.text +  " is not found</color>.";
        }
    }






}
