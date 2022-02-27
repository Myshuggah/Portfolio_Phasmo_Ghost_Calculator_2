using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]
public class ParentButtonComponents
{
    public Button buttonBox;
    public Image imageBox;
    public Text buttonTextBox;


    public void GettingTheComponents()
    {
        buttonBox = GameObject.FindObjectOfType<Button>().GetComponent<Button>();
        imageBox = GameObject.FindObjectOfType<Button>().GetComponent<Image>();
        buttonTextBox = GameObject.FindObjectOfType<Text>().GetComponent<Text>();
    }

}

    //Example use of class(Template)
    //public ParentButtonComponents[] "Insert Variable Name Here"; (To Call the Class)

//"Insert Variable Name Here"[0].buttonBox.enabled = true;
//"Insert Variable Name Here"[0].imageBox.enabled = true;
//"Insert Variable Name Here"[0].buttonTextBox.enabled = true;

//"Insert Variable Name Here"[0].buttonBox.enabled = false;
//"Insert Variable Name Here"[0].imageBox.enabled = false;
//"Insert Variable Name Here"[0].buttonTextBox.enabled = false;

