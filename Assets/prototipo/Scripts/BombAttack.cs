using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class BombAttack : MonoBehaviour {

	public GameObject explosion;
	float tiempo = 1.0f;
	float cuentaAtras = GamePlay.cuentaAtras; //temps avans de explotar.
//	bool contador = false;	
//	bool destructor = false;
//	public bool comparate = false;

	// en cada update de frame aumenta 1 segon el temps.
//	void Update () {
//		if (contador == true) {
//			tiempo += Time.deltaTime; 
//			if (tiempo > cuentaAtras) {
//			destructor = true;	
//		//		contador = false;
//				print ("fin del tiempo");
//
////				if (Collision.gameObject.tag == "baldosa") {
////					Destroy (Collision.gameObject);
//			}
//		//		contador = false;
////				Instantiate (explosion, transform.position, Quaternion.identity);//genera gameObject esplosion.
////				Destroy (gameObject);
//		}
//	}
	void OnCollisionStay (Collision baldosa){
//		if (contador == true) {
			tiempo += Time.deltaTime; 
			if (tiempo > cuentaAtras) {
				if (baldosa.gameObject.tag == "baldosa") {
					Destroy (baldosa.gameObject);
					Instantiate (explosion, transform.position, Quaternion.identity);//genera gameObject esplosion.
					Destroy (gameObject);
				}
			}
	}
//	}
	//quan te contacte amb el terra posa en marxa el contador.
//	void OnCollisionEnter(Collision colision) {
//		contador = true;
//		print ("colision true");
//	}

	//durant la colisió si el temps a pasat activa la destrucció de la baldosa.
//	void OnCollisionStay (Collision baldosa) {
//	if (destructor == true) {
//			print ("listo destructor!!!!!! ");
//			if (baldosa.gameObject.tag == "baldosa") {
//				Destroy (baldosa.gameObject);
//				print ("colision ok, destruye!!");
//				Instantiate (explosion, transform.position, Quaternion.identity);//genera gameObject esplosion.
//				Destroy (gameObject);
//			}
//
//
//
//		}
//	}

}

