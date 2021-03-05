using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollRemove : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Torch") {
			gameObject.SetActive(false);
		}
	}

}
