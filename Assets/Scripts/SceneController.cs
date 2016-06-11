using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public Image fundido;
	public string[] NameEscenas;
	// Use this for initialization
	void Start () {
		
		fundido.CrossFadeAlpha (0, 1, false);
	}

	public void fadeOut(int index){
		Debug.Log ("Holaa");
		fundido.CrossFadeAlpha (1, 1, false);
		StartCoroutine (iniciarEscena (NameEscenas[index]));
	}


	IEnumerator iniciarEscena(string escena){

		yield return new WaitForSeconds (1);
		SceneManager.LoadScene (escena);
	}
}
