using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightController : MonoBehaviour
{
	float currHeight = 50f;
	public float minHeight = 20f;
	public float maxHeight = 40f;

	private void Start() {
		transform.position = new Vector3(transform.position.x, currHeight, transform.position.z);
	}

	private void Update() {
		if (Input.GetKey(KeyCode.Space)) {
			HeightTest();

			currHeight -= Time.deltaTime * 10f;
			if (currHeight < 0)
				currHeight = 0;
			transform.position = new Vector3(transform.position.x, currHeight, transform.position.z);
		}
	}

	void HeightTest() {
		if (currHeight > maxHeight)
			print("too high");
		else if (currHeight < minHeight)
			print("too low");
		else
			print("just right, Icarus would be jealous");
	}
}
