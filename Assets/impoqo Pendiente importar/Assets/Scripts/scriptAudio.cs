using UnityEngine;
using System.Collections;

public class scriptAudio : MonoBehaviour {
	//public int startingPitch = 10;
	//public int timeToDecrease = 10;
	AudioSource sonido;

	void Start() {
		sonido = GetComponent<AudioSource>();
		sonido.pitch = Random.Range(1,2.5f);
	}

	//void Update() {
		/*if (audio.pitch > 0)
			audio.pitch += Time.deltaTime * startingPitch / timeToDecrease;
	}*/
}
