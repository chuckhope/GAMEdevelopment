using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_ok : MonoBehaviour {
    public GameObject help_module;
    // Use this for initialization
    void Start () {
		
	}
 
    public void changeFunc()
    {
        help_module.SetActive(false);
    }

    public void closeHelp()
    {
        Invoke("changeFunc", 1);//1秒后调用LaunchProjectile () 函数，之后每5秒调用一次

    }
    // Update is called once per frame
    void Update () {
		
	}
}
