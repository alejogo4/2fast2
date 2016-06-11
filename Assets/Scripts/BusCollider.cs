using UnityEngine;
using System.Collections;

public class BusCollider : MonoBehaviour {

	private SoundController sonidos;
	private Cronometro tiempo;

	// Use this for initialization
	void Start () {
		sonidos = FindObjectOfType<SoundController> ();
		tiempo = FindObjectOfType<Cronometro>();
	}


	void OnTriggerEnter2D(Collider2D obj){
		if (obj.tag == "Player") {
			Destroy (this.gameObject);
			sonidos.reproducirAudio (0);
			tiempo.Tiempo = tiempo.Tiempo - 10;
		}
	}

}
