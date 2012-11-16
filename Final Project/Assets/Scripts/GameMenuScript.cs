using UnityEngine;
using System.Collections;

public class GameMenuScript : MonoBehaviour {
	public Texture2D GamePaused;
	
	// Use this for initialization
	void Start () {
		// Update PlayerPrefs -> "GreatestLevel"
		PlayerPrefs.SetInt("GreatestLevel",Application.loadedLevel);
		Time.timeScale=1.0f;
		Screen.showCursor=false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// GUI code
	void OnGUI() {
		// If the game isn't paused then GUI
		if(Time.timeScale==0) {
			// Draw background
			GUI.Box(new Rect(5,5,Screen.width-10,Screen.height-10), "");
			
			GUI.BeginGroup(new Rect(Screen.width/2-250,Screen.height/4,500,250));
			// Game Paused text
			GUI.DrawTexture(new Rect(0,0,500,200),GamePaused);
			GUI.EndGroup();
			
			// Start main button area
			GUILayout.BeginArea(new Rect(Screen.width/2-75,3*Screen.height/4,150,300));
			if(GUILayout.Button("Resume")){
				// Resume the game
				Time.timeScale=1.0f;
				Screen.showCursor=false;
			}
			if(GUILayout.Button("Save and Quit")){
				Application.LoadLevel("GameStart");
			}
			GUILayout.EndArea();
		}
	}
}
