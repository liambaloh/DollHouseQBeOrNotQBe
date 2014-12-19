﻿using UnityEngine;
using System.Collections;

public class UIStateBarLabel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (GameController.SelectedPlayer == null)
        {
            this.guiText.enabled = false;
        } else
        {
            this.guiText.enabled = true;
        }
	}
}
