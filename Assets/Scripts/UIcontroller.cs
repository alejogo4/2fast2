using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour {
	public GameObject panel;
	public Text Score_txt;
	// Use this for initialization
	void Start () {
	
	}

	public void mostrarPanel(){
		
		panel.SetActive (true);
	}

	public void mostrarScore(float Score){
		Score_txt.text = ((int)Score).ToString ()+" MTS";
	}



	// Update is called once per frame
	void Update () {
	
	}
}
