using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GamePause()
    {

        Time.timeScale = 0;
    }
}
