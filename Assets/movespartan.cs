using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movespartan : MonoBehaviour {
	public Transform[] target;
	public float speed;
	private Vector3 startingPosition;
	private int i = 0;
	// Use this for initialization
	void Start () {
		startingPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (i < target.Length) {
			if (Vector3.Distance (transform.position, target [i].position) > 0) {
				transform.position = Vector3.MoveTowards (transform.position, target [i].position, speed * Time.deltaTime);
			} else {
				i++;
			}
		} else {
			transform.position = startingPosition;
			i = 0;
		}
	}
}
