using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {

	private Coche Carro;
	public float velocidad;
	public float anguloGiro;
	// Use this for initialization

	void Start () {
		Carro = FindObjectOfType<Coche> ();
	}
	
	// Update is called once per frame
	void Update () {
		float anguloZ = 0;
		transform.Translate (Vector2.right* Input.GetAxis ("Horizontal") * velocidad * Time.deltaTime);
		anguloZ = Input.GetAxis ("Horizontal") * anguloGiro;
		Carro.transform.rotation = Quaternion.Euler (0, 0, -anguloZ);
	}
}
