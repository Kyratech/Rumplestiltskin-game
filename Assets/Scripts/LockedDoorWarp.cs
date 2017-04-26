using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LockedDoorWarp : SceneWarp {

	public InspectTile lockedInspect;

	public void ExitRoom() {
		if (controller.hasKey) {
        	controller.warpID = warpID;
			SceneManager.LoadScene(sceneToLoad);
		}
		else {
			lockedInspect.toggleDialog();
		}
	}

}