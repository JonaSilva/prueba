using UnityEngine;
using System.Collections;

public class FechaObjetivo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().material.color= new Color(1.0f,0.0f,0.0f,0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
