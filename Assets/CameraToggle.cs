using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle : MonoBehaviour {
    public GameObject ThirdPerson;
    public GameObject FirstPerson;
	// Use this for initialization
	void Start () {
        ThirdPerson.SetActive(true);
        FirstPerson.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("CamToggle"))
        {
            //simply inverst the active states
            ThirdPerson.SetActive(!ThirdPerson.activeSelf);
            FirstPerson.SetActive(!FirstPerson.activeSelf);
        }
	}
}
