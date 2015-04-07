using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float speed = 1f;
	public Transform target;

	// Use this for initialization
	void Start () {

		target.position = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);

	}
}
