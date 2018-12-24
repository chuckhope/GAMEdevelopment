using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
    public void changeFunc()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void quit_game()
    {
        Invoke("changeFunc", 1);//1秒后调用LaunchProjectile () 函数，之后每5秒调用一次

    }
}
