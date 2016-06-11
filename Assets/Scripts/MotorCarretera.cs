using UnityEngine;
using System.Collections;

public class MotorCarretera : MonoBehaviour {

	public float velociad;
	public bool inicioGame = false;
	public bool finalGame = false;

	void Start () {
		InicioJuego ();
	}

	void InicioJuego(){
		IniciarVelocidad ();

	}

	void IniciarVelocidad(){
		velociad = 18;
	}

	void Update () {
		if (inicioGame && !finalGame) {
			transform.Translate (Vector3.down * velociad * Time.deltaTime);
		}
	}
}
