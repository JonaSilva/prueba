#pragma strict
var estilo:GUIStyle;
var uno:AudioClip;
var dos:AudioClip;
var tres:AudioClip;
var cuatro:AudioClip;
var cinco:AudioClip;
var seis:AudioClip;
var numero:int;


function Start () {
	
}




function Update () {
	


}

function OnGUI(){
	//GUI.Label(Rect(Screen.width/3,0,Screen.width/3*2,Screen.height/6),"La Toma de Zacatecas",estilo);
	var jn:boolean=GUI.Button(Rect(Screen.width/22*8,Screen.height/19*4,Screen.width/22*6,Screen.height/19*2),"Juego Nuevo");
	var co:boolean=GUI.Button(Rect(Screen.width/22*8,Screen.height/19*7,Screen.width/22*6,Screen.height/19*2),"Continuar");
	var ga:boolean=GUI.Button(Rect(Screen.width/22*8,Screen.height/19*10,Screen.width/22*6,Screen.height/19*2),"Galerias");
	var cr:boolean=GUI.Button(Rect(Screen.width/22*8,Screen.height/19*13,Screen.width/22*6,Screen.height/19*2),"Creditos");
	var op:boolean=GUI.Button(Rect(Screen.width/22*8,Screen.height/19*16,Screen.width/22*6,Screen.height/19*2),"Opciones");
	var s:boolean=GUI.Button(Rect(Screen.width/22*16,Screen.height/19*16,Screen.width/22*4,Screen.height/19*2),"!Salir");
	if(jn){
		Application.LoadLevel(1);

	}
	/*if(p2){
		Application.LoadLevel(4);
	}*/
	if(ga){
		Application.LoadLevel(2);}
	if(op){
		Application.LoadLevel(6);}
	if(s){//salida
		Application.Quit();}
}