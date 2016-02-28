﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	private int firstlevel = 1;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.R))
        {
            boat.mRunning = false;
            // reset score
            scoreManager.UpdateScore(0);
            SceneManager.LoadScene(firstlevel); 
        }
	}
}
