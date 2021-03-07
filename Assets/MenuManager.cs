using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject pauseMenu;
	public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

	bool isPaused = false;

	float tempXSens = 2;
	float tempYSens = 2;

	void Start() {
		PauseGame(false);
	}

	private void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			PauseGame(!isPaused);
		}

	}

	public void ResumeGame() {
		print("resume button pressed");
		PauseGame(false);
	}

	public void PauseGame(bool doPause) {
		isPaused = doPause;
		Cursor.visible = isPaused;
		pauseMenu.SetActive(isPaused);

		var mouseLook = controller.GetMouseLook();
		if (isPaused) {
			tempXSens = mouseLook.XSensitivity;
			tempYSens = mouseLook.YSensitivity;
			mouseLook.XSensitivity = 0;
			mouseLook.YSensitivity = 0;
			Time.timeScale = 0.0001f;
		}
		else {
			mouseLook.XSensitivity = tempXSens;
			mouseLook.YSensitivity = tempYSens;
			Time.timeScale = 1;
		}
	}
}
