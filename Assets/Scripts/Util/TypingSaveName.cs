using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingSaveName : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text; 
    }

    
    private void Update()
    {
        if (playerName.Length >= 2 || playerName.Length <= 10)
        { EnterMain(); }
        else
        { denyAccess(); }
    }

    private void denyAccess()
    {
        
    }

    private void EnterMain()
    {
        playerName = playerNameInput.text;

    }
}
