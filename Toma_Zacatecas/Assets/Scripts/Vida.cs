using UnityEngine;
using System.Collections;

public class Vida : MonoBehaviour {
	float puntosActuales;
	int contador, suma;
	private Animator anim;
	float puntosDeVida=1f;
	private Collider colaider;
	//public AudioClip myClip;
	void Start () {
		contador = 0;
		suma = 0;

		puntosActuales = puntosDeVida;
		anim = GetComponent<Animator> ();
		colaider = GetComponent<Collider> ();
		//Debug.Log ( "Suma " + suma + "Contador " + contador);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void danio(float amt){
		puntosActuales -= amt;
		if (puntosActuales<=0){
			morir();
		}
	}

	void morir(){
		//Debug.Log("MORIIIIIIIIIIIIIIII");
		//Destroy (gameObject);
		if(gameObject.tag=="jarron"){
			

			anim.SetBool ("explosion", true);
			Destroy (colaider);

	
		}
		if(gameObject.tag=="enemigo"){
			anim.SetBool ("muerte", true);
			//Debug.Log("MUERTEEEEEEEEEEEEEEEEEEE");
			//Destroy (colaider);

		}


		//AudioSource.PlayClipAtPoint(myClip, transform.position);
	}
	//cargar(){
		
	//	}
}
