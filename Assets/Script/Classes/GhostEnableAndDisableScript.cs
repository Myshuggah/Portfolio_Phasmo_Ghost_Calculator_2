using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]
public class GhostEnableAndDisableScript
{
    public Button ghostButtonEnabler;
    public Image ghostButtonEnablerImage;
    public Text ghostButtonEnablerText;

    public void GettingTheComponentsOfGhostButtons()
    {
        ghostButtonEnabler = GameObject.FindObjectOfType<Button>().GetComponent<Button>();
        ghostButtonEnablerImage = GameObject.FindObjectOfType<Button>().GetComponent<Image>();
        ghostButtonEnablerText = GameObject.FindObjectOfType<Text>().GetComponent<Text>();
    }

}
