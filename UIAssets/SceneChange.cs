using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("GoNextScene", 19);//1秒后调用LaunchProjectile () 函数，之后每5秒调用一次

    }
    public void GoNextScene()
    {
        Application.LoadLevel("level 1");//切换到场景Scene
    }


    // Update is called once per frame
    void Update () {
		
	}
}
