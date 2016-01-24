using UnityEngine;
using System.Collections;

public class Opciones : MonoBehaviour {
	string[] asd=new string[4];
	int a;
	float b;
	string asdd;

	// Use this for initialization
	void Start () {
		a = 3;
		b = 1;
		asd [0] = "800x600";
		asd [1] = "1024x768";
		asd [2] = "1080x900";
		asd [3] = "1366x768";
	}
	
	// Update is called once per frame
	void Update () {
		switch (a) {
		case 0:{
			Screen.SetResolution(800,600,false);
			asdd=asd[0];
		}break;
		case 1:{
			Screen.SetResolution(1024,768,true);
			asdd=asd[1];
		}break;
		case 2:{
			Screen.SetResolution(1080,900,true);
			asdd=asd[2];
		}break;
		case 3:{
			Screen.SetResolution(1366,768,true);
			asdd=asd[3];
		}break;
		}
	}

	void OnGUI(){
		GUI.Label(new Rect(Screen.width/22*10,Screen.height/19*2,Screen.width/22*10,Screen.height/19),"Resolucion: "+asdd);
		a=GUI.Toolbar(new Rect(Screen.width/22*10,Screen.height/19*4,Screen.width/22*10,Screen.height/19),a,asd);
		if (GUI.Button(new Rect(Screen.width/22*16,Screen.height/19*16,Screen.width/22*4,Screen.height/19*2),"!Atras")) {
			Application.LoadLevel(0);
		}
		b=GUI.HorizontalSlider(new Rect(Screen.width/22*10,Screen.height/19*10,Screen.width/22*10,Screen.height/19),b,0,1);
		GUI.Label(new Rect(Screen.width/22*10,Screen.height/19*9,Screen.width/22*10,Screen.height/19),"Volumen: "+decimal.Round((decimal)b*100,2)+"%");
		AudioListener.volume = b;
	}
}
