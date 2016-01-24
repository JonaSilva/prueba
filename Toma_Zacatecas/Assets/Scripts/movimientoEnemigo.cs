using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class movimientoEnemigo : MonoBehaviour {
	private Transform jugador;
	private GameObject abj;
	//charMove charMove;
	// Use this for initialization
	private NavMeshAgent nav;

	void wake(){


	}
	void Start (){
		nav = GetComponent<NavMeshAgent> ();
		//abj = GameObject.Find ("/FPSController");
		jugador = GameObject.FindGameObjectWithTag ("jugador").transform;
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (jugador.position);
	}

}