using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlayerTrigger : MonoBehaviour
{
	public GameObject objectToRemove;

	private void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			objectToRemove.SetActive(false);
		}
	}
}
