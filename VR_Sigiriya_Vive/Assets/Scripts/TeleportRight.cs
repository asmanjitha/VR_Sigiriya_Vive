using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using Valve.VR;

public class TeleportRight : MonoBehaviour {

	public Vector3 currentPoint;
	private Vector3[] positionArray = new Vector3[4];
	public GameObject Player;
	private bool inc;
	private bool  dec;
	SteamVR_TrackedObject controller;
	 
 	

	// Use this for initialization
	void Start () {
		controller = gameObject.GetComponent<SteamVR_TrackedObject>();
		positionArray[0] = new Vector3(6.0f,2.0f,0.0f);            
 		positionArray[1] = new Vector3(10.1f,2.0f,2.1f);
 		positionArray[2] = new Vector3(15.6f,2.0f,15.2f);

		currentPoint = positionArray[2];
		this.inc = false;
		this.dec = false;
		Player.transform.position = currentPoint;
	}
	
	// Update is called once per frame
	private void Update () {
		
		
		if (Input.GetAxis("openvr-r-trigger-press") > 0.2){
			if (currentPoint == positionArray[0]){
				currentPoint = positionArray[2];
			}else if (currentPoint == positionArray[1]){
				currentPoint = positionArray[0];
			}else if (currentPoint == positionArray[2]){
				currentPoint = positionArray[1];
			}
			Player.transform.position = currentPoint;
		}
	}

	
}
