using UnityEngine;
using System.Collections;

public class Crear_pieza : MonoBehaviour {

	public GameObject pieza;
	public GameObject contenedorPiezas;

	public GameObject BusObstaculo;
	public float xMax, xMin;

	// Use this for initialization
	void Start () {
		
	}
	
	public void CrearPieza(){
		Vector2 spawnPosition = new Vector2 (Random.Range (xMax, -xMin), transform.position.y);
		GameObject pieza_nueva = Instantiate(pieza, new Vector3(0,10.1f,0), transform.rotation) as GameObject;
		pieza_nueva.transform.parent = contenedorPiezas.transform;

		int aleatorio = Random.Range (0, 3);
		if (aleatorio == 1) {
			GameObject randomObs = Instantiate (BusObstaculo, spawnPosition, transform.rotation) as GameObject;
			randomObs.transform.parent = pieza_nueva.transform;
		}
	}


}
