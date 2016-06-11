using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour {

	public Text Tiempo_txt;
	public Text Distancia_txt;

	private float Distancia;
	public float Tiempo;

	private MotorCarretera carretera;

	private UIcontroller controladorUI;
	private Coche Carro;
	// Use this for initialization

	void Start () {
		carretera = FindObjectOfType<MotorCarretera> ();
		Carro = FindObjectOfType<Coche> ();
		controladorUI = FindObjectOfType<UIcontroller> ();
		Tiempo_txt.text = "2:00";
		Distancia_txt.text = "0";
		Tiempo = 120;


	}
	
	// Update is called once per frame
	void Update () {
		if (carretera.inicioGame && !carretera.finalGame) {
			calcularTiempoDistancia ();
		}

		if (Tiempo <= 0) {
			carretera.finalGame = true;
			controladorUI.mostrarPanel ();
			controladorUI.mostrarScore (Distancia);
			Carro.GetComponent<AudioSource> ().Stop();
			Tiempo_txt.text = "0:00";
		}
	}

	void calcularTiempoDistancia(){
		
		Distancia += Time.deltaTime * carretera.velociad;
		Distancia_txt.text = ((int)Distancia).ToString ();

		Tiempo -= Time.deltaTime;
		int minutos = (int)Tiempo / 60;
		int segundos = (int)Tiempo % 60;

		Tiempo_txt.text = minutos.ToString () + ":" + segundos.ToString ().PadLeft(2,'0');
	}
}
