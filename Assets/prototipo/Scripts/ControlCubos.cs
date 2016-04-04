using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControlCubos : MonoBehaviour {

	// cubos de la escena
	public GameObject cuboAmarillo;
	public GameObject cuboRojo;
	public GameObject cuboAzul;
	public GameObject cuboFucsia;
	public GameObject cuboVerde;
//	public GameObject cuboBlanco;
	//lista vacia 
	static public List<GameObject> listaCubos = new List<GameObject>();
	//añade los cubos a la lista si estan activos.
	void FixedUpdate(){
		if (GameManager.enableAmarillo == true){
			listaCubos.Add (cuboAmarillo);
		}
		if (GameManager.enableRojo == true){
			listaCubos.Add (cuboRojo);
		}
		if (GameManager.enableAzul == true){
			listaCubos.Add (cuboAzul);
		}
		if (GameManager.enableFucsia == true){
			listaCubos.Add (cuboFucsia);
		}
		if (GameManager.enableVerde == true){
			listaCubos.Add (cuboVerde);
		}
//		if (GameManager.enableBlanco == true){
//			listaCubos.Add (cuboBlanco);
//		}
	}
	//funcion que si es envocada activa todos los cubos.
	static public void cubosEnable(){
		GameManager.enableAmarillo = true;
		GameManager.enableRojo = true;
		GameManager.enableAzul = true;
		GameManager.enableFucsia = true;
		GameManager.enableVerde = true;
//		GameManager.enableBlanco = true;
	}
	// funcion que desactiva el cubo de la ultima posicion.
	static public void cubosPosicion(){

		if (GameManager.posicion == GameManager.lastAmarillo){
			GameManager.enableAmarillo = false;
		}
		if (GameManager.posicion == GameManager.lastRojo){
			GameManager.enableRojo = false;
		}
		if (GameManager.posicion == GameManager.lastAzul){
			GameManager.enableAzul = false;
		}
		if (GameManager.posicion == GameManager.lastFucsia){
			GameManager.enableFucsia = false;
		}
		if (GameManager.posicion == GameManager.lastVerde){
			GameManager.enableVerde = false;
		}
//		if (GameManager.posicion == GameManager.lastBlanco){
//			GameManager.enableBlanco = false;
//		}
	}
}
