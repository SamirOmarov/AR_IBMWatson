using MalbersAnimations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceLogic : MonoBehaviour
{
    
    public Button button;
    public Animal animal;
    // Use this for initialization

    /*void Update()
    {

        button = GetComponent<Button>();
    } */
        public void FoxActions(string ActionCommands)
    {

        ActionCommands = ActionCommands.Trim();

        if (ActionCommands == "sit")
        {
            //GetComponent<Button>().onClick.Invoke();
            animal.SetAction(11);
        }
        else if (ActionCommands == "eat")
            {
                //GetComponent<Button>().onClick.Invoke();
                animal.SetAction(2);
            }


    }
    // Update is called once per frame



}


