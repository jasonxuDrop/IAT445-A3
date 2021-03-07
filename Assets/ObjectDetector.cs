using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{
	public bool isTorchInView;
	public bool isWebInView;

	private void OnTriggerEnter(Collider other) {
		Torch torch = other.GetComponent<Torch>();
		Web web = other.GetComponent<Web>();

		if (torch) {
			isTorchInView = true;
		}
		if (web) {
			isWebInView = true;
		}
	}

	private void OnTriggerExit(Collider other) {
		Torch torch = other.GetComponent<Torch>();
		Web web = other.GetComponent<Web>();

		if (torch) {
			isTorchInView = false;
		}
		if (web) {
			isWebInView = false;
		}
	}
}
