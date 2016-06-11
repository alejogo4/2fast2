using UnityEngine;
using System.Collections;

public class CuentaAtras : MonoBehaviour {

	public Sprite[] numeros;
	public SpriteRenderer SpriteNumeros;
	public GameObject numerosSprite;
	public GameObject controladorCoche;
	public GameObject Coche;

	private MotorCarretera carretera;

	// Use this for initialization
	void Start () {
		IniciarComponentes ();
	}

	void IniciarComponentes(){

		numerosSprite = GameObject.Find ("numeros");
		SpriteNumeros = numerosSprite.GetComponent<SpriteRenderer> ();
		controladorCoche = GameObject.Find ("ControladorCoche");
		Coche = GameObject.Find ("Coche");
		StartCoroutine (cuentaRegresiva ());
		carretera = FindObjectOfType<MotorCarretera> ();
	}

	IEnumerator cuentaRegresiva(){

		controladorCoche.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (2);

		SpriteNumeros.sprite = numeros [1];
		gameObject.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (1);

		SpriteNumeros.sprite = numeros [2];
		gameObject.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (1);

		SpriteNumeros.sprite = numeros [3];
		carretera.inicioGame = true;
		numerosSprite.GetComponent<AudioSource> ().Play ();
		Coche.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (2);

		numerosSprite.SetActive (false);
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
