﻿using UnityEngine;
using System.Collections;


public class clickAndDrag : MonoBehaviour {
	
	float distance = 1;

	private Vector3 screenPoint;
	private Vector3 offset;
	private float lockedYPos;

	void OnMouseDrag() {
		Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objectPos = Camera.main.ScreenToWorldPoint(screenPosition) + offset;

		transform.position = objectPos;
	}

	void OnMouseDown(){
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
		offset.z = 0;
		Cursor.visible = false;
	}

	void OnMouseUp(){
		Cursor.visible = true;
	}




}