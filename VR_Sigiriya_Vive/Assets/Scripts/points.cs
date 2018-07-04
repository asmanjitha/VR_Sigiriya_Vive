using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour {

	public Vector3 currentPoint;
	private Vector3[] positionArray = new Vector3[4];
	public GameObject Player;
	private bool inc;
	private bool  dec;
	 
 	

	// Use this for initialization
	void Start () {
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
		
		if (Input.GetKeyDown("Joystick key 8") ){
			if (currentPoint == positionArray[0]){
				currentPoint = positionArray[1];
			}else if (currentPoint == positionArray[1]){
				currentPoint = positionArray[2];
			}else if (currentPoint == positionArray[2]){
				currentPoint = positionArray[0];
			}
			Player.transform.position = currentPoint;
			//Player.transform.position += Player.transform.forward * 2.0f * Time.deltaTime;
			//Player.transform.GetComponent("Wall (1)").destination = currentPoint;
			//FollowPoint();
		}
		if (Input.GetKeyDown("Joystick key 9")){
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
