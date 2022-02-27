using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]
public class GhostDetailsButtonScript
{
    public Button ghostDetailsButton;
    public Image ghostDetailsButtonImage;
    public Text ghostDetailsButtonText;


    public void GettingTheComponents()
    {
        ghostDetailsButton = GameObject.FindObjectOfType<Button>().GetComponent<Button>();
        ghostDetailsButtonImage = GameObject.FindObjectOfType<Button>().GetComponent<Image>();
        ghostDetailsButtonText = GameObject.FindObjectOfType<Text>().GetComponent<Text>();
    }

}

//Template

//"Insert Variable Name Here"[0].ghostDetailsButton.enabled = false;
//"Insert Variable Name Here"[0].ghostDetailsButtonImage.enabled = false;
//"Insert Variable Name Here"[0].ghostDetailsButtonText.enabled = false;

//"Insert Variable Name Here"[0].ghostDetailsButton.enabled = true;
//"Insert Variable Name Here"[0].ghostDetailsButtonImage.enabled = true;
//"Insert Variable Name Here"[0].ghostDetailsButtonText.enabled = true;