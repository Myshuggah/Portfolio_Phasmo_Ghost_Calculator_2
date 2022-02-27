using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]

public class SelectedTextActivator 
{
    public Text evidenceSelectedText;

    public void GettingTheText()
    {
        evidenceSelectedText = GameObject.FindObjectOfType<Text>().GetComponent<Text>();

    }

    //Example use of class(Template)
    //public SelectedTextActivator[] "Insert Variable Name Here";

    //"Insert Variable Name Here"[0].evidenceSelectedText.enabled = false;
    
    //"Insert Variable Name Here"[0].evidenceSelectedText.enabled = true;
}
