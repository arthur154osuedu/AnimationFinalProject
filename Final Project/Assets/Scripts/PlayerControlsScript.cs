using UnityEngine;
using System.Collections;

public class PlayerControlsScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// If ESC is pressed pause the game
		if(Input.GetKey(KeyCode.Escape)){
			// Pause game
			Time.timeScale=0;
			Screen.showCursor=true;
			// Disable the player control script
		}
	}
}
