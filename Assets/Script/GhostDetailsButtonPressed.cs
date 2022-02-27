using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GhostDetailsButtonPressed : MonoBehaviour
{
    public GhostDetailsButtonScript[] ghostDetailsButtonScript;

    //Booleans
    public bool bansheeDetailsButtonPressedBool = false;
    public bool demonDetailsButtonPressedBool = false;
    public bool goryoDetailsButtonPressedBool = false;
    public bool hantuDetailsButtonPressedBool = false;
    public bool jinnDetailsButtonPressedBool = false;
    public bool mareDetailsButtonPressedBool = false;
    public bool mylingDetailsButtonPressedBool = false;
    public bool oniDetailsButtonPressedBool = false;
    public bool phantomDetailsButtonPressedBool = false;
    public bool poltergeistDetailsButtonPressedBool = false;
    public bool revenantDetailsButtonPressedBool = false;
    public bool shadeDetailsButtonPressedBool = false;
    public bool spiritDetailsButtonPressedBool = false;
    public bool wraithDetailsButtonPressedBool = false;
    public bool yokaiDetailsButtonPressedBool = false;
    public bool yureiDetailsButtonPressedBool = false;

    public void BansheeDetailsButtonPressedMethod()
    {
        if (bansheeDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[0].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[0].ghostDetailsButtonText.enabled = false;

            //Booleans
            bansheeDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[0].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[0].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[0].ghostDetailsButtonText.enabled = true;

            //Booleans
            bansheeDetailsButtonPressedBool = true;
        }
    }

    public void DemonDetailsButtonPressedMethod()
    {
        if (demonDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[1].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[1].ghostDetailsButtonText.enabled = false;

            //Booleans
            demonDetailsButtonPressedBool = false;
        }
        else
        {
            ghostDetailsButtonScript[1].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[1].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[1].ghostDetailsButtonText.enabled = true;

            //Booleans
            demonDetailsButtonPressedBool = true;
        }
    }

    public void GoryoDetailsButtonPressedMethod()
    {
        if (goryoDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[2].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[2].ghostDetailsButtonText.enabled = false;

            //Booleans
            goryoDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[2].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[2].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[2].ghostDetailsButtonText.enabled = true;

            //Booleans
            goryoDetailsButtonPressedBool = true;
        }
    }
    public void HantuDetailsButtonPressedMethod()
    {
        if (hantuDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[3].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[3].ghostDetailsButtonText.enabled = false;

            //Booleans
            hantuDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[3].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[3].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[3].ghostDetailsButtonText.enabled = true;

            //Booleans
            hantuDetailsButtonPressedBool = true;
        }
    }
    public void JinnDetailsButtonPressedMethod()
    {
        if (jinnDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[4].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[4].ghostDetailsButtonText.enabled = false;

            //Booleans
            jinnDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[4].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[4].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[4].ghostDetailsButtonText.enabled = true;

            //Booleans
            jinnDetailsButtonPressedBool = true;
        }
    }
    public void MareDetailsButtonPressedMethod()
    {
        if (mareDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[5].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[5].ghostDetailsButtonText.enabled = false;

            //Booleans
            mareDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[5].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[5].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[5].ghostDetailsButtonText.enabled = true;

            //Booleans
            mareDetailsButtonPressedBool = true;
        }
    }
    public void MylingDetailsButtonPressedMethod()
    {
        if (mylingDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[6].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[6].ghostDetailsButtonText.enabled = false;

            //Booleans
            mylingDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[6].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[6].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[6].ghostDetailsButtonText.enabled = true;

            //Booleans
            mylingDetailsButtonPressedBool = true;
        }
    }
    public void OniDetailsButtonPressedMethod()
    {
        if (oniDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[7].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[7].ghostDetailsButtonText.enabled = false;

            //Booleans
            oniDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[7].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[7].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[7].ghostDetailsButtonText.enabled = true;

            //Booleans
            oniDetailsButtonPressedBool = true;
        }
    }
    public void PhantomDetailsButtonPressedMethod()
    {
        if (phantomDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[8].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[8].ghostDetailsButtonText.enabled = false;

            //Booleans
            phantomDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[8].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[8].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[8].ghostDetailsButtonText.enabled = true;

            //Booleans
            phantomDetailsButtonPressedBool = true;
        }
    }
    public void PoltergeistDetailsButtonPressedMethod()
    {
        if (poltergeistDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[9].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[9].ghostDetailsButtonText.enabled = false;

            //Booleans
            poltergeistDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[9].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[9].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[9].ghostDetailsButtonText.enabled = true;

            //Booleans
            poltergeistDetailsButtonPressedBool = true;
        }
    }
    public void RevenantDetailsButtonPressedMethod()
    {
        if (revenantDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[10].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[10].ghostDetailsButtonText.enabled = false;

            //Booleans
            revenantDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[10].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[10].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[10].ghostDetailsButtonText.enabled = true;

            //Booleans
            revenantDetailsButtonPressedBool = true;
        }
    }
    public void ShadeDetailsButtonPressedMethod()
    {
        if (shadeDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[11].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[11].ghostDetailsButtonText.enabled = false;

            //Booleans
            shadeDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[11].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[11].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[11].ghostDetailsButtonText.enabled = true;

            //Booleans
            shadeDetailsButtonPressedBool = true;
        }
    }
    public void SpiritDetailsButtonPressedMethod()
    {
        if (spiritDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[12].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[12].ghostDetailsButtonText.enabled = false;

            //Booleans
            spiritDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[12].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[12].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[12].ghostDetailsButtonText.enabled = true;

            //Booleans
            spiritDetailsButtonPressedBool = true;
        }
    }
    public void WraithDetailsButtonPressedMethod()
    {
        if (wraithDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[13].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[13].ghostDetailsButtonText.enabled = false;

            //Booleans
            wraithDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[13].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[13].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[13].ghostDetailsButtonText.enabled = true;

            //Booleans
            wraithDetailsButtonPressedBool = true;
        }
    }
    public void YokaiDetailsButtonPressedMethod()
    {
        if (yokaiDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[14].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[14].ghostDetailsButtonText.enabled = false;

            //Booleans
            yokaiDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[14].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[14].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[14].ghostDetailsButtonText.enabled = true;

            //Booleans
            yokaiDetailsButtonPressedBool = true;
        }
    }
    public void YureiDetailsButtonPressedMethod()
    {
        if (yureiDetailsButtonPressedBool == true)
        {
            //Disabling ghost detail button Components
            ghostDetailsButtonScript[15].ghostDetailsButton.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButtonImage.enabled = false;
            ghostDetailsButtonScript[15].ghostDetailsButtonText.enabled = false;

            //Booleans
            yureiDetailsButtonPressedBool = false;
        }
        else
        {
            //Enabling ghost detail button Components
            ghostDetailsButtonScript[15].ghostDetailsButton.enabled = true;
            ghostDetailsButtonScript[15].ghostDetailsButtonImage.enabled = true;
            ghostDetailsButtonScript[15].ghostDetailsButtonText.enabled = true;

            //Booleans
            yureiDetailsButtonPressedBool = true;
        }
    }
}

//ghostDetailsButtonScript[0] = Banshee
//ghostDetailsButtonScript[1] = Demon
//ghostDetailsButtonScript[2] = Goryo
//ghostDetailsButtonScript[3] = Hantu
//ghostDetailsButtonScript[4] = Jinn
//ghostDetailsButtonScript[5] = Mare
//ghostDetailsButtonScript[6] = Myling
//ghostDetailsButtonScript[7] = Oni
//ghostDetailsButtonScript[8] = Phantom
//ghostDetailsButtonScript[9] = Poltergeist
//ghostDetailsButtonScript[10] = Revenant
//ghostDetailsButtonScript[11] = Shade
//ghostDetailsButtonScript[12] = Spirit
//ghostDetailsButtonScript[13] = Wraith
//ghostDetailsButtonScript[14] = Yokai
//ghostDetailsButtonScript[15] = Yurei

//ghostDetailsButtonScript[0].ghostDetailsButton.enabled = false;
//ghostDetailsButtonScript[0].ghostDetailsButtonImage.enabled = false;
//ghostDetailsButtonScript[0].ghostDetailsButtonText.enabled = false;

//ghostDetailsButtonScript[0].ghostDetailsButton.enabled = true;
//ghostDetailsButtonScript[0].ghostDetailsButtonImage.enabled = true;
//ghostDetailsButtonScript[0].ghostDetailsButtonText.enabled = true;