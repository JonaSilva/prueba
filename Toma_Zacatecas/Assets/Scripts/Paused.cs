using UnityEngine;
using System.Collections;

public class Paused : MonoBehaviour {
	public bool paused;
	// Use this for initialization
	void Start () {
		paused = false;
		Debug.Log(Time.timeScale);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp("p")) {
			paused=true;
		}
		if (paused) {
			Screen.lockCursor=false;
			Time.timeScale=0;
		} else {
			Screen.lockCursor=true;
			Time.timeScale=1;
		}
	}
	void OnGUI(){
		if (paused) {
			if (GUI.Button(new Rect(Screen.width/22*16,Screen.height/19*16,Screen.width/22*4,Screen.height/19*2),"!Salir")) {
				Application.LoadLevel (0);
			}
			if (GUI.Button(new Rect(Screen.width/22*1,Screen.height/19*16,Screen.width/22*4,Screen.height/19*2),"Continuar")) {
				paused=false;
			}
		}
	}
	public void cargarPartida(){
		
	}
	public void guardarPartida(){
		
	}
}
