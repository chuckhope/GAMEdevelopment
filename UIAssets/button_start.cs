using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button_start : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
    public void GoNextScene()
    {
        Invoke("changeFunc", 1);//1秒后调用LaunchProjectile () 函数，之后每5秒调用一次

    }
    public void changeFunc()
    {
        Application.LoadLevel("BackgroundAnimation");//切换到场景Scene
    }

    // Update is called once per frame
    void Update () {
		
	}
    
}
