using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigLeft : MonoBehaviour {

	public Vector3 currentPoint;
	private Vector3[] positionArray = new Vector3[4];
	public GameObject Player;
	SteamVR_TrackedController controller;

	// Use this for initialization
	void Start() {
  	controller = GetComponent<SteamVR_TrackedController>();
  	controller.TriggerClicked += DoClick;
	positionArray[0] = new Vector3(6.0f,3.0f,0.0f);            
 	positionArray[1] = new Vector3(10.1f,3.0f,2.1f);
	positionArray[2] = new Vector3(15.6f,3.0f,15.2f);
	currentPoint = positionArray[2];
	Player.transform.position = currentPoint;
  	
}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoClick(object s, ClickedEventArgs e){
    // Do whatever you want to do here, I just want to print.
	if (currentPoint == positionArray[0]){
			currentPoint = positionArray[1];
		}else if (currentPoint == positionArray[1]){
			currentPoint = positionArray[2];
		}else if (currentPoint == positionArray[2]){
			currentPoint = positionArray[0];
		}
		Player.transform.position = currentPoint;
	}
}
