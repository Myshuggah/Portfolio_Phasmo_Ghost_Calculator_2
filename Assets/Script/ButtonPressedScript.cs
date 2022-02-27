using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonPressedScript : MonoBehaviour
{
    public ParentButtonComponents[] parentButtonComponents;
    public SelectedTextActivator[] selectextTextActivator;
    public GhostEnableAndDisableScript[] ghostEnableAndDisableScripts;
    public GhostDetailsButtonScript[] ghostDetailsButtonScript;
    public GhostDetailsButtonPressed ghostDetailsButtonPressed;
    
    //Booleans
    public bool emfButtonPressedBool = false;
    public bool fingerprintsButtonPressedBool = false;
    public bool freezingTempButtonPressedBool = false;
    public bool ghostOrbButtonPressedBool = false;
    public bool ghostWritingButtonPressedBool = false;
    public bool spiritBoxButtonPressedBool = false;
    public bool dotsProjectorButtonPressdBool = false;

    
    
    public void EMFButtonPressedMethod()
    {

        if (emfButtonPressedBool == true)
        {
            //Enabling Button Components
            parentButtonComponents[3].buttonBox.enabled = true;
            parentButtonComponents[3].imageBox.enabled = true;
            parentButtonComponents[3].buttonTextBox.enabled = true;

            //Disabling evidence selected text Text Components
            selectextTextActivator[0].evidenceSelectedText.enabled = false;

            //Enabling Ghost Button
            ghostDetailsButtonPressed = GameObject.Find("Ghost Details Button Object").GetComponent<GhostDetailsButtonPressed>();
            ghostDetailsButtonPressed.bansheeDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.demonDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.hantuDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.mareDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.phantomDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.poltergeistDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.revenantDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.yokaiDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.yureiDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerText.enabled = true;
            /*ghostDetailsButtonScript[0].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[0].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[0].ghostDetailsButtonText.enabled = true;*/

            /*//Enabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.SetActive(true);*/

            //Booleans
            //ghostDetailsButtonPressed.bansheeDetailsButtonPressedBool = !ghostDetailsButtonPressed.bansheeDetailsButtonPressedBool;
            //ghostDetailsButtonPressed.bansheeDetailsButtonPressedBool = false;
            emfButtonPressedBool = false;
        }
        else
        {
            //Disable Button Components
            parentButtonComponents[3].buttonBox.enabled = false;
            parentButtonComponents[3].imageBox.enabled = false;
            parentButtonComponents[3].buttonTextBox.enabled = false;

            //Enabling evidence selected text Text Components
            selectextTextActivator[0].evidenceSelectedText.enabled = true;

            //Disabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[1].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[3].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[5].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[8].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[9].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[10].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[14].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[15].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButtonText.enabled = false;
            /*//Disabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.SetActive(false);*/

            //Booleans
            //ghostDetailsButtonPressed.bansheeDetailsButtonPressedBool = false;
            emfButtonPressedBool = true;
        }
        CheckIfIHaveToTurnSpiritBoxOff();
        CheckIfIHaveToTurnDOTSOff();
        CheckIfIHaveToTurnGhostWritingOff();
        CheckIfIHaveToTurnGhostOrbOff();
        CheckIfIHaveToTurnEMF5Off();
        CheckIfIHaveToTurnFreezingTempOff();
        CheckIfIHaveToTurnFingerprintsOff();
    }
    public void FingerPrintsPressedMethod()
    {
        if (fingerprintsButtonPressedBool == true)
        {
            //Disabling evidence selected text Text Components
            selectextTextActivator[1].evidenceSelectedText.enabled = false;

            //Enabling Ghost Button
            ghostDetailsButtonPressed = GameObject.Find("Ghost Details Button Object").GetComponent<GhostDetailsButtonPressed>();
            ghostDetailsButtonPressed.mareDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.oniDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.revenantDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.shadeDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.spiritDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.wraithDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.yokaiDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.yureiDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerText.enabled = true;

            /*//Enabling Ghost Button
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.SetActive(true);*/
            //57101112131415

            //Booleans
            fingerprintsButtonPressedBool = false;
        }
        else
        {
            //Enabling evidence selected text Text Components
            selectextTextActivator[1].evidenceSelectedText.enabled = true;

            //Disabling Ghost Button
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[7].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[10].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[11].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[12].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[13].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[14].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[15].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButtonText.enabled = false;


            /*//Enabling Ghost Button
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.SetActive(false);*/

            //Booleans
            fingerprintsButtonPressedBool = true;
        }
        CheckIfIHaveToTurnSpiritBoxOff();
        CheckIfIHaveToTurnDOTSOff();
        CheckIfIHaveToTurnGhostWritingOff();
        CheckIfIHaveToTurnGhostOrbOff();
        CheckIfIHaveToTurnEMF5Off();
        CheckIfIHaveToTurnFreezingTempOff();
        CheckIfIHaveToTurnFingerprintsOff();


        //Disabling Ghost Button
        //ghostEnableAndDisableScripts[5].ghostButtonEnabler.SetActive(false);
        //ghostEnableAndDisableScripts[7].ghostButtonEnabler.SetActive(false);
        //ghostEnableAndDisableScripts[10].ghostButtonEnabler.SetActive(false);
        //ghostEnableAndDisableScripts[11].ghostButtonEnabler.SetActive(false);
        //ghostEnableAndDisableScripts[12].ghostButtonEnabler.SetActive(false);
        //ghostEnableAndDisableScripts[13].ghostButtonEnabler.SetActive(false);
        //ghostEnableAndDisableScripts[14].ghostButtonEnabler.SetActive(false);
        //ghostEnableAndDisableScripts[15].ghostButtonEnabler.SetActive(false);
    }

    public void FreezingTempPressedMethod()
    {
        if (freezingTempButtonPressedBool == true)
        {
            //Enabling Button Components
            parentButtonComponents[5].buttonBox.enabled = true;
            parentButtonComponents[5].imageBox.enabled = true;
            parentButtonComponents[5].buttonTextBox.enabled = true;

            //Disabling evidence selected text Text Components
            selectextTextActivator[2].evidenceSelectedText.enabled = false;

            //Enabling Ghost Button
            ghostDetailsButtonPressed = GameObject.Find("Ghost Details Button Object").GetComponent<GhostDetailsButtonPressed>();
            ghostDetailsButtonPressed.bansheeDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.goryoDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.mareDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.mylingDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.phantomDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.poltergeistDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.spiritDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.wraithDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.yokaiDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerText.enabled = true;
            /*//Enabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.SetActive(true);*/

            //Booleans
            freezingTempButtonPressedBool = false;
        }
        else 
        {
            //Disabling Button Component
            parentButtonComponents[5].buttonBox.enabled = false;
            parentButtonComponents[5].imageBox.enabled = false;
            parentButtonComponents[5].buttonTextBox.enabled = false;

            //Enabling evidence selected text Text Components
            selectextTextActivator[2].evidenceSelectedText.enabled = true;

            //Disabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[2].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[5].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[6].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[8].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[9].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[12].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[13].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[14].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButtonText.enabled = false;

            /*//Disabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.SetActive(false);*/

            //Booleans
            freezingTempButtonPressedBool = true;
        }
        CheckIfIHaveToTurnSpiritBoxOff();
        CheckIfIHaveToTurnDOTSOff();
        CheckIfIHaveToTurnGhostWritingOff();
        CheckIfIHaveToTurnGhostOrbOff();
        CheckIfIHaveToTurnEMF5Off();
        CheckIfIHaveToTurnFreezingTempOff();
        CheckIfIHaveToTurnFingerprintsOff();
    }
    public void GhostOrbPressedMethod()
    {
        if (ghostOrbButtonPressedBool == true)
        {
            //Enabling Button Components
            parentButtonComponents[0].buttonBox.enabled = true;
            parentButtonComponents[0].imageBox.enabled = true;
            parentButtonComponents[0].buttonTextBox.enabled = true;

            //Disabling evidence selected text Text Components
            selectextTextActivator[3].evidenceSelectedText.enabled = false;

            //Enabling Ghost Button
            ghostDetailsButtonPressed = GameObject.Find("Ghost Details Button Object").GetComponent<GhostDetailsButtonPressed>();
            ghostDetailsButtonPressed.demonDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.goryoDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.jinnDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.mylingDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.oniDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.phantomDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.poltergeistDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.shadeDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.spiritDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.wraithDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerText.enabled = true;


            /*//Enabling Ghost Button
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.SetActive(true);*/

            //Booleans
            ghostOrbButtonPressedBool = false;
        }
        else
        {
            //Disabling Button Component
            parentButtonComponents[0].buttonBox.enabled = false;
            parentButtonComponents[0].imageBox.enabled = false;
            parentButtonComponents[0].buttonTextBox.enabled = false;

            //Enabling evidence selected text Text Components
            selectextTextActivator[3].evidenceSelectedText.enabled = true;

            //Disabling Ghost Button
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[2].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[4].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[6].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[7].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[8].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[9].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[11].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[12].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[13].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButtonText.enabled = false;
            /*//Disabling Ghost Button
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.SetActive(false);*/

            //Booleans
            ghostOrbButtonPressedBool = true;
        }
        CheckIfIHaveToTurnSpiritBoxOff();
        CheckIfIHaveToTurnDOTSOff();
        CheckIfIHaveToTurnGhostWritingOff();
        CheckIfIHaveToTurnGhostOrbOff();
        CheckIfIHaveToTurnEMF5Off();
        CheckIfIHaveToTurnFreezingTempOff();
        CheckIfIHaveToTurnFingerprintsOff();
    }
    public void GhostWritingPressedMethod()
    {
        if (ghostWritingButtonPressedBool == true)
        {
            //Enabling Button Components
            parentButtonComponents[6].buttonBox.enabled = true;
            parentButtonComponents[6].imageBox.enabled = true;
            parentButtonComponents[6].buttonTextBox.enabled = true;

            //Disabling evidence selected text Text Components
            selectextTextActivator[4].evidenceSelectedText.enabled = false;

            //Enabling Ghost Button
            ghostDetailsButtonPressed = GameObject.Find("Ghost Details Button Object").GetComponent<GhostDetailsButtonPressed>();
            ghostDetailsButtonPressed.bansheeDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.goryoDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.hantuDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.jinnDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.oniDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.phantomDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.wraithDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.yokaiDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.yureiDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerText.enabled = true;

            /*//Enabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.SetActive(true);*/
            //023478131415
            //Booleans
            ghostWritingButtonPressedBool = false;
        }
        else
        {
            //Disabling Button Component
            parentButtonComponents[6].buttonBox.enabled = false;
            parentButtonComponents[6].imageBox.enabled = false;
            parentButtonComponents[6].buttonTextBox.enabled = false;

            //Enabling evidence selected text Text Components
            selectextTextActivator[4].evidenceSelectedText.enabled = true;

            //Disabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[2].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[3].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[4].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[7].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[8].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[8].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[13].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[13].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[14].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[14].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[15].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButtonText.enabled = false;


            /*//Disabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[8].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[13].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[14].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.SetActive(false);*/
            //023478131415

            //Booleans
            ghostWritingButtonPressedBool = true;
        }
        CheckIfIHaveToTurnSpiritBoxOff();
        CheckIfIHaveToTurnDOTSOff();
        CheckIfIHaveToTurnGhostWritingOff();
        CheckIfIHaveToTurnGhostOrbOff();
        CheckIfIHaveToTurnEMF5Off();
        CheckIfIHaveToTurnFreezingTempOff();
        CheckIfIHaveToTurnFingerprintsOff();
    } 
    public void SpiritBoxPressedMethod()
    {
        if (spiritBoxButtonPressedBool == true)
        {
            //Enabling Button Components
            parentButtonComponents[2].buttonBox.enabled = true;
            parentButtonComponents[2].imageBox.enabled = true;
            parentButtonComponents[2].buttonTextBox.enabled = true;

            //Disabling evidence selected text Text Components
            selectextTextActivator[5].evidenceSelectedText.enabled = false;

            //Enabling Ghost Button
            ghostDetailsButtonPressed = GameObject.Find("Ghost Details Button Object").GetComponent<GhostDetailsButtonPressed>();
            ghostDetailsButtonPressed.bansheeDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.demonDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.goryoDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.hantuDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.jinnDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.mylingDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.oniDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.revenantDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.shadeDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.yureiDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerText.enabled = true;

            /*//Enabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.SetActive(true);*/
            //0123467101115

            //Booleans
            spiritBoxButtonPressedBool = false;
        }
        else
        {
            //Disabling Button Component
            parentButtonComponents[2].buttonBox.enabled = false;
            parentButtonComponents[2].imageBox.enabled = false;
            parentButtonComponents[2].buttonTextBox.enabled = false;

            //Enabling evidence selected text Text Components
            selectextTextActivator[5].evidenceSelectedText.enabled = true;

            //Disabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[0].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[1].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[2].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[2].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[3].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[4].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[6].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[7].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[7].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[10].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[11].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[15].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[15].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButtonText.enabled = false;

            /*//Disabling Ghost Button
            ghostEnableAndDisableScripts[0].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[2].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[7].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[15].ghostButtonEnabler.SetActive(false);*/

            //Booleans
            spiritBoxButtonPressedBool = true;

        }
        CheckIfIHaveToTurnSpiritBoxOff();
        CheckIfIHaveToTurnDOTSOff();
        CheckIfIHaveToTurnGhostWritingOff();
        CheckIfIHaveToTurnGhostOrbOff();
        CheckIfIHaveToTurnEMF5Off();
        CheckIfIHaveToTurnFreezingTempOff();
        CheckIfIHaveToTurnFingerprintsOff();
    }
    public void DOTSPressedMethod()
    {
        if (dotsProjectorButtonPressdBool == true)
        {
            //Enabling Button Components
            parentButtonComponents[4].buttonBox.enabled = true;
            parentButtonComponents[4].imageBox.enabled = true;
            parentButtonComponents[4].buttonTextBox.enabled = true;

            //Disabling evidence selected text Text Components
            selectextTextActivator[6].evidenceSelectedText.enabled = false;

            //Enabling Ghost Button
            ghostDetailsButtonPressed = GameObject.Find("Ghost Details Button Object").GetComponent<GhostDetailsButtonPressed>();
            ghostDetailsButtonPressed.demonDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.hantuDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.jinnDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.mareDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.mylingDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.poltergeistDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.revenantDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.shadeDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerText.enabled = true;

            ghostDetailsButtonPressed.spiritDetailsButtonPressedBool = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.enabled = true;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerImage.enabled = true;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerText.enabled = true;

            /*//Enabling Ghost Button
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.SetActive(true);
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.SetActive(true);*/
            //134569101112

            //Booleans
            dotsProjectorButtonPressdBool = false;
        }
        else
        {
            //Disabling Button Component
            parentButtonComponents[4].buttonBox.enabled = false;
            parentButtonComponents[4].imageBox.enabled = false;
            parentButtonComponents[4].buttonTextBox.enabled = false;

            //Enabling evidence selected text Text Components
            selectextTextActivator[6].evidenceSelectedText.enabled = true;

            //Disabling Ghost Button
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[1].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[3].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[3].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[4].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[4].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[5].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[5].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[6].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[6].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[9].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[9].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[10].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[10].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[11].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[11].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButtonText.enabled = false;

            ghostEnableAndDisableScripts[12].ghostButtonEnabler.enabled = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerImage.enabled = false;
            ghostEnableAndDisableScripts[12].ghostButtonEnablerText.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButtonText.enabled = false;


            /*//Disabling Ghost Button
            ghostEnableAndDisableScripts[1].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[3].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[4].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[5].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[6].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[9].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[10].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[11].ghostButtonEnabler.SetActive(false);
            ghostEnableAndDisableScripts[12].ghostButtonEnabler.SetActive(false);*/

            //Booleans
            dotsProjectorButtonPressdBool = true;

        }
        CheckIfIHaveToTurnSpiritBoxOff();
        CheckIfIHaveToTurnDOTSOff();
        CheckIfIHaveToTurnGhostWritingOff();
        CheckIfIHaveToTurnGhostOrbOff();
        CheckIfIHaveToTurnEMF5Off();
        CheckIfIHaveToTurnFreezingTempOff();
        CheckIfIHaveToTurnFingerprintsOff();
    }
    void CheckIfIHaveToTurnSpiritBoxOff()
    {
        bool hasEMFBeenClicked = emfButtonPressedBool;
        bool hasFingerprintsBeenClicked = fingerprintsButtonPressedBool;

        if (hasEMFBeenClicked && hasFingerprintsBeenClicked)
        {
            parentButtonComponents[5].buttonBox.enabled = false;
            parentButtonComponents[5].imageBox.enabled = false;
            parentButtonComponents[5].buttonTextBox.enabled = false;
        }
        else if (hasFingerprintsBeenClicked && freezingTempButtonPressedBool)
        {
            parentButtonComponents[5].buttonBox.enabled = false;
            parentButtonComponents[5].imageBox.enabled = false;
            parentButtonComponents[5].buttonTextBox.enabled = false;
        }
        else if (hasFingerprintsBeenClicked && ghostOrbButtonPressedBool)
        {
            parentButtonComponents[5].buttonBox.enabled = false;
            parentButtonComponents[5].imageBox.enabled = false;
            parentButtonComponents[5].buttonTextBox.enabled = false;
        }
        else if (freezingTempButtonPressedBool)
        {
            parentButtonComponents[5].buttonBox.enabled = false;
            parentButtonComponents[5].imageBox.enabled = false;
            parentButtonComponents[5].buttonTextBox.enabled = false;
        }
        else
        {
            parentButtonComponents[5].buttonBox.enabled = true;
            parentButtonComponents[5].imageBox.enabled = true;
            parentButtonComponents[5].buttonTextBox.enabled = true;
        }
    }
    
    void CheckIfIHaveToTurnDOTSOff() 
    {
        bool hasFreezingTempBeenClicked = freezingTempButtonPressedBool;
        bool hasFingerprintsBeenClicked = fingerprintsButtonPressedBool;

        if (hasFreezingTempBeenClicked && hasFingerprintsBeenClicked)
        {
            parentButtonComponents[6].buttonBox.enabled = false;
            parentButtonComponents[6].imageBox.enabled = false;
            parentButtonComponents[6].buttonTextBox.enabled = false;
        }
        else if (hasFingerprintsBeenClicked && ghostWritingButtonPressedBool)
        {
            parentButtonComponents[6].buttonBox.enabled = false;
            parentButtonComponents[6].imageBox.enabled = false;
            parentButtonComponents[6].buttonTextBox.enabled = false;
        }
        else if (ghostWritingButtonPressedBool)
        {
            parentButtonComponents[6].buttonBox.enabled = false;
            parentButtonComponents[6].imageBox.enabled = false;
            parentButtonComponents[6].buttonTextBox.enabled = false;
        }
        else
        {
            parentButtonComponents[6].buttonBox.enabled = true;
            parentButtonComponents[6].imageBox.enabled = true;
            parentButtonComponents[6].buttonTextBox.enabled = true;
        }
    }

    void CheckIfIHaveToTurnGhostWritingOff()
    {
        bool hasGhostOrbBeenClicked = ghostOrbButtonPressedBool;
        bool hasFingerprintsBeenClicked = fingerprintsButtonPressedBool;

        if (hasGhostOrbBeenClicked && hasFingerprintsBeenClicked)
        {
            parentButtonComponents[4].buttonBox.enabled = false;
            parentButtonComponents[4].imageBox.enabled = false;
            parentButtonComponents[4].buttonTextBox.enabled = false;
        }
        else if (hasFingerprintsBeenClicked && dotsProjectorButtonPressdBool)
        {
            parentButtonComponents[4].buttonBox.enabled = false;
            parentButtonComponents[4].imageBox.enabled = false;
            parentButtonComponents[4].buttonTextBox.enabled = false;
        }
        else if (dotsProjectorButtonPressdBool)
        {
            parentButtonComponents[4].buttonBox.enabled = false;
            parentButtonComponents[4].imageBox.enabled = false;
            parentButtonComponents[4].buttonTextBox.enabled = false;
        }
        else if (hasFingerprintsBeenClicked && emfButtonPressedBool && freezingTempButtonPressedBool)
        {
            parentButtonComponents[4].buttonBox.enabled = false;
            parentButtonComponents[4].imageBox.enabled = false;
            parentButtonComponents[4].buttonTextBox.enabled = false;
        }
        else
        {
            parentButtonComponents[4].buttonBox.enabled = true;
            parentButtonComponents[4].imageBox.enabled = true;
            parentButtonComponents[4].buttonTextBox.enabled = true;
        }
    }
    void CheckIfIHaveToTurnGhostOrbOff()
    {
        bool hasGhostWritingBeenClicked = ghostWritingButtonPressedBool;
        bool hasFingerprintsBeenCLicked = fingerprintsButtonPressedBool;

        if (hasGhostWritingBeenClicked && hasFingerprintsBeenCLicked)
        {
            parentButtonComponents[3].buttonBox.enabled = false;
            parentButtonComponents[3].imageBox.enabled = false;
            parentButtonComponents[3].buttonTextBox.enabled = false;
        }
        else if (hasFingerprintsBeenCLicked && spiritBoxButtonPressedBool)
        {
            parentButtonComponents[3].buttonBox.enabled = false;
            parentButtonComponents[3].imageBox.enabled = false;
            parentButtonComponents[3].buttonTextBox.enabled = false;
        }
        else if (hasFingerprintsBeenCLicked && emfButtonPressedBool)
        {
            parentButtonComponents[3].buttonBox.enabled = false;
            parentButtonComponents[3].imageBox.enabled = false;
            parentButtonComponents[3].buttonTextBox.enabled = false;
        }
        else if (hasFingerprintsBeenCLicked && ghostWritingButtonPressedBool)
        {
            parentButtonComponents[3].buttonBox.enabled = false;
            parentButtonComponents[3].imageBox.enabled = false;
            parentButtonComponents[3].buttonTextBox.enabled = false;
        }
        else if (emfButtonPressedBool)
        {
            parentButtonComponents[3].buttonBox.enabled = false;
            parentButtonComponents[3].imageBox.enabled = false;
            parentButtonComponents[3].buttonTextBox.enabled = false;
        }
        else
        {
            parentButtonComponents[3].buttonBox.enabled = true;
            parentButtonComponents[3].imageBox.enabled = true;
            parentButtonComponents[3].buttonTextBox.enabled = true;
        }
    }

    void CheckIfIHaveToTurnEMF5Off()
    {
        bool hasSpiritBoxBeenClicked = spiritBoxButtonPressedBool;
        bool hasFingerprintsBeenClicked = fingerprintsButtonPressedBool;

        if (hasSpiritBoxBeenClicked && hasFingerprintsBeenClicked)
        {
            parentButtonComponents[0].buttonBox.enabled = false;
            parentButtonComponents[0].imageBox.enabled = false;
            parentButtonComponents[0].buttonTextBox.enabled = false;
        }
        else if (hasFingerprintsBeenClicked && ghostOrbButtonPressedBool)
        {
            parentButtonComponents[0].buttonBox.enabled = false;
            parentButtonComponents[0].imageBox.enabled = false;
            parentButtonComponents[0].buttonTextBox.enabled = false;
        }
        else if (ghostOrbButtonPressedBool)
        {
            parentButtonComponents[0].buttonBox.enabled = false;
            parentButtonComponents[0].imageBox.enabled = false;
            parentButtonComponents[0].buttonTextBox.enabled = false;
        }
        else if (fingerprintsButtonPressedBool && ghostWritingButtonPressedBool && freezingTempButtonPressedBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else
        {
            parentButtonComponents[0].buttonBox.enabled = true;
            parentButtonComponents[0].imageBox.enabled = true;
            parentButtonComponents[0].buttonTextBox.enabled = true;
        }
    }

    void CheckIfIHaveToTurnFreezingTempOff()
    {
        bool hasDOTSBeenClicked = dotsProjectorButtonPressdBool;
        bool hasFingerprintsBeenClicked = fingerprintsButtonPressedBool;

        if(hasDOTSBeenClicked && hasFingerprintsBeenClicked)
        {
            parentButtonComponents[2].buttonBox.enabled = false;
            parentButtonComponents[2].imageBox.enabled = false;
            parentButtonComponents[2].buttonTextBox.enabled = false;
        }
        else if(hasFingerprintsBeenClicked && spiritBoxButtonPressedBool)
        {
            parentButtonComponents[2].buttonBox.enabled = false;
            parentButtonComponents[2].imageBox.enabled = false;
            parentButtonComponents[2].buttonTextBox.enabled = false;
        }
        else if(spiritBoxButtonPressedBool)
        {
            parentButtonComponents[2].buttonBox.enabled = false;
            parentButtonComponents[2].imageBox.enabled = false;
            parentButtonComponents[2].buttonTextBox.enabled = false;
        }
        else if (hasFingerprintsBeenClicked && emfButtonPressedBool && ghostWritingButtonPressedBool == true)
        {
            parentButtonComponents[2].buttonBox.enabled = false;
            parentButtonComponents[2].imageBox.enabled = false;
            parentButtonComponents[2].buttonTextBox.enabled = false;
        }
        else
        {
            parentButtonComponents[2].buttonBox.enabled = true;
            parentButtonComponents[2].imageBox.enabled = true;
            parentButtonComponents[2].buttonTextBox.enabled = true;
        }
    }
    void CheckIfIHaveToTurnFingerprintsOff()
    {
        bool hasFingerprintsBeenClicked = fingerprintsButtonPressedBool;

        if (emfButtonPressedBool && freezingTempButtonPressedBool && ghostWritingButtonPressedBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else if (emfButtonPressedBool && freezingTempButtonPressedBool && dotsProjectorButtonPressdBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else if (emfButtonPressedBool && freezingTempButtonPressedBool && ghostWritingButtonPressedBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else if (emfButtonPressedBool && spiritBoxButtonPressedBool && ghostWritingButtonPressedBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else if (emfButtonPressedBool && spiritBoxButtonPressedBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else if (ghostOrbButtonPressedBool && spiritBoxButtonPressedBool && dotsProjectorButtonPressdBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else if (ghostOrbButtonPressedBool && spiritBoxButtonPressedBool && ghostWritingButtonPressedBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else if (ghostOrbButtonPressedBool && spiritBoxButtonPressedBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else if (ghostOrbButtonPressedBool && ghostWritingButtonPressedBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else if (ghostOrbButtonPressedBool && freezingTempButtonPressedBool && dotsProjectorButtonPressdBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else if (freezingTempButtonPressedBool && dotsProjectorButtonPressdBool == true)
        {
            parentButtonComponents[1].buttonBox.enabled = false;
            parentButtonComponents[1].imageBox.enabled = false;
            parentButtonComponents[1].buttonTextBox.enabled = false;
        }
        else
        {
            parentButtonComponents[1].buttonBox.enabled = true;
            parentButtonComponents[1].imageBox.enabled = true;
            parentButtonComponents[1].buttonTextBox.enabled = true;
        }
    }
}

// parentButtonComponents[0] = EMF Level 5
// parentButtonComponents[1] = Fingerprints
// parentButtonComponents[2] = Freezing Temperature
// parentButtonComponents[3] = Ghost Orb
// parentButtonComponents[4] = Ghost Writing
// parentButtonComponents[5] = Spirit Box
// parentButtonComponents[6] = D.O.T.S. Projector

// selectextTextActivator[0] = EMF Level 5
// selectextTextActivator[1] = Fingerprints
// selectextTextActivator[2] = Freezing Temperature
// selectextTextActivator[3] = Ghost Orb
// selectextTextActivator[4] = Ghost Writing
// selectextTextActivator[5] = Spirit Box
// selectextTextActivator[6] = D.O.T.S. Projector

//ghostEnableAndDisableScripts[0] = Banshee
//ghostEnableAndDisableScripts[1] = Damon
//ghostEnableAndDisableScripts[2] = Goryo
//ghostEnableAndDisableScripts[3] = Hantu
//ghostEnableAndDisableScripts[4] = Jinn
//ghostEnableAndDisableScripts[5] = Mare
//ghostEnableAndDisableScripts[6] = Myling
//ghostEnableAndDisableScripts[7] = Oni
//ghostEnableAndDisableScripts[8] = Phantom
//ghostEnableAndDisableScripts[9] = Poltergeis
//ghostEnableAndDisableScripts[10] = Revenant
//ghostEnableAndDisableScripts[11] = Shade
//ghostEnableAndDisableScripts[12] = Spirit
//ghostEnableAndDisableScripts[13] = Wraith
//ghostEnableAndDisableScripts[14] = Yokai
//ghostEnableAndDisableScripts[15] = Yurei

/*ghostEnableAndDisableScripts[0].ghostButtonEnabler.enabled = false;
ghostEnableAndDisableScripts[0].ghostButtonEnablerImage.enabled = false;
ghostEnableAndDisableScripts[0].ghostButtonEnablerText.enabled = false;
ghostDetailsButtonScript[0].ghostDetailsButton.enabled = false;
ghostDetailsButtonScript[0].ghostDetailsButtonImage.enabled = false;
ghostDetailsButtonScript[0].ghostDetailsButtonText.enabled = false;*/

