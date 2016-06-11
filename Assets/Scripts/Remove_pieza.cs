using UnityEngine;
using System.Collections;

public class Remove_pieza : MonoBehaviour {

	private Crear_pieza CreadorDePiezas;

	void Start () {

		CreadorDePiezas = FindObjectOfType<Crear_pieza> ();

	}
		
	void OnTriggerEnter2D(Collider2D obj){
	
		CreadorDePiezas.CrearPieza ();
		Destroy (obj.gameObject);
	}





}
