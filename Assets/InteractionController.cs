using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    public ObjectDetector objectDetector;

    public GameObject torchObj;

    private Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {

            // play animation for torch
            if (torchObj && torchObj.activeSelf) {
                anim = torchObj.GetComponent<Animator>();
                anim.SetTrigger("use");
            }

			if (objectDetector.isTorchInView) {
                if (torchObj) {
                    torchObj.SetActive(true);
				}

                var torches = FindObjectsOfType<Torch>();
				foreach (Torch torch in torches) {
                    Destroy(torch.gameObject);
				}

                anim = torchObj.GetComponent<Animator>();
                anim.SetTrigger("pickup");
            }

            if (objectDetector.isWebInView) {
                // burn the web
                var web = FindObjectOfType<Web>();
                var webAnim = web.gameObject.GetComponent<Animator>();
                webAnim.SetTrigger("burn");
            }
		}
    }
}
