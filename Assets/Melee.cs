using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour {
	
	public int Damage = 50;
	public float Distance;
	public float Range = 1.5f; 
	public string message;

	public void Update() {
		if (Input.GetButtonDown("Fire1")) {
			RaycastHit hit;
			if (Input.GetButton("SwingLeft") && !Input.GetButton("SwingRight")) {
				HorizontalSwingLeft();
			} else if (Input.GetButton("SwingRight") && !Input.GetButton("SwingLeft")) {
				HorizontalSwingRight();
			}
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit)) {
				Distance = hit.distance;
				if (Distance < Range) {
					hit.transform.SendMessage ("ApplyDamage", Damage, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}

	void HorizontalSwingLeft() {
		message = "SwingLeft";
	}

	void HorizontalSwingRight() {
		message = "SwingRight";
	}
}
