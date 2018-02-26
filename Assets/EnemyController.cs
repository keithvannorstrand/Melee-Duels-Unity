using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public float health;

	// Use this for initialization
	void Start () {
		health = 100;
	}

	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Dead();
		}
	}

	void ApplyDamage (int damage) {
		health -= damage;
	}

	void Dead() {
		Destroy (gameObject);
	}
}
