﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OPTIONS_MENU_SCRIPT : MonoBehaviour 
{
    public Canvas optionsMenu;
    public Button backText;

	// Use this for initialization
	void Start() 
    {
        backText = backText.GetComponent<Button>();
        optionsMenu = optionsMenu.GetComponent<Canvas>();
	}
	
	public void BackPress()
    {
        Application.LoadLevel(0);
    }
}
