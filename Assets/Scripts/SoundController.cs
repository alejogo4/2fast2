using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {

	public AudioClip[] Sonidos;
	private AudioSource Audio; 
	// Use this for initialization
	void Start () {
		Audio = GetComponent<AudioSource> ();
	}

	public void reproducirAudio(int id){
		Audio.clip = Sonidos [id];
		Audio.Play ();
	}

}
