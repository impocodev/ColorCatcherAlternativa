using UnityEngine;
using System.Collections;

public class RastreadorCubos : MonoBehaviour {


void FixedUpdate () {
		if (GameManager.Blanco >= GameManager.full) {
			GameManager.enableBlanco = false;
		} 
	}
	//oriol.  encolision con trigger.
	void OnTriggerEnter (Collider col){
		switch (col.gameObject.tag)
		{
		case "Amarillo":
				GameManager.Amarillo++;// añade 1 al contador.
				GameManager.enableAmarillo = false;// desactiva el cubo en cuenstion, y evita que se repita la ejecucion del mismo color.
				if (col.transform.position.x < 0 && col.transform.position.z > 0) {
					//N0 = 1
					GameManager.lastAmarillo = 1;
				} else if (col.transform.position.x > 0 && col.transform.position.z > 0) {
					//NE = 2
					GameManager.lastAmarillo = 2;
				} else if (col.transform.position.x < 0 && col.transform.position.z < 0) {
					//SO = 3
					GameManager.lastAmarillo = 3;
				} else if (col.transform.position.x > 0 && col.transform.position.z < 0) {
					//SE = 4
					GameManager.lastAmarillo = 4;
				}
				print ("ultima posicion amarillo:"+ GameManager.lastAmarillo);
				break;
		case "Rojo":
				GameManager.Rojo++;
				GameManager.enableRojo = false;
				if (col.transform.position.x < 0 && col.transform.position.z > 0) {
					//N0 = 1
					GameManager.lastRojo = 1;
				} else if (col.transform.position.x > 0 && col.transform.position.z > 0) {
					//NE = 2
					GameManager.lastRojo = 2;
				} else if (col.transform.position.x < 0 && col.transform.position.z < 0) {
					//SO = 3
					GameManager.lastRojo = 3;
				}  else if (col.transform.position.x > 0 && col.transform.position.z < 0) {
					//SE = 4
					GameManager.lastRojo = 4;
				}
				print ("ultima posicion rojo:"+ GameManager.lastRojo);
				break;
			case "Azul":
				GameManager.Azul++;
				GameManager.enableAzul = false;
				if (col.transform.position.x < 0 && col.transform.position.z > 0) {
					//N0 = 1
					GameManager.lastAzul = 1;
				} else if (col.transform.position.x > 0 && col.transform.position.z > 0) {
					//NE = 2
					GameManager.lastAzul = 2;
				} else if (col.transform.position.x < 0 && col.transform.position.z < 0) {
					//SO = 3
					GameManager.lastAzul = 3;
				}  else if (col.transform.position.x > 0 && col.transform.position.z < 0) {
					//SE = 4
					GameManager.lastAzul = 4;
				}
				print ("ultima posicion azul:"+ GameManager.lastAzul);
				break;
			case "Fucsia":
				GameManager.Fucsia++;
				GameManager.enableFucsia = false;
				if (col.transform.position.x < 0 && col.transform.position.z > 0) {
						//N0 = 1
					GameManager.lastFucsia = 1;
				} else if (col.transform.position.x > 0 && col.transform.position.z > 0) {
					//NE = 2
					GameManager.lastFucsia = 2;
				} else if (col.transform.position.x < 0 && col.transform.position.z < 0) {
					//SO = 3
					GameManager.lastFucsia = 3;
				}  else if (col.transform.position.x > 0 && col.transform.position.z < 0) {
					//SE = 4
					GameManager.lastFucsia = 4;
				}
				print ("ultima posicion fucsia:"+ GameManager.lastFucsia);	
				break;
			case "Verde":
				GameManager.Verde++;
				GameManager.enableVerde = false;
				if (col.transform.position.x < 0 && col.transform.position.z > 0) {
					//N0 = 1
					GameManager.lastVerde = 1;
				} else if (col.transform.position.x > 0 && col.transform.position.z > 0) {
					//NE = 2
					GameManager.lastVerde = 2;
				} else if (col.transform.position.x < 0 && col.transform.position.z < 0) {
					//SO = 3
					GameManager.lastVerde = 3;
				}  else if (col.transform.position.x > 0 && col.transform.position.z < 0) {
					//SE = 4
					GameManager.lastVerde = 4;
				}
				print ("ultima posicion verde:"+ GameManager.lastVerde);
				break;
			case "Blanco":
				GameManager.Blanco++;
				GameManager.enableBlanco = false;
				if (col.transform.position.x < 0 && col.transform.position.z > 0) {
					//N0 = 1
					GameManager.lastBlanco = 1;
				} else if (col.transform.position.x > 0 && col.transform.position.z > 0) {
					//NE = 2
					GameManager.lastBlanco = 2;
				} else if (col.transform.position.x < 0 && col.transform.position.z < 0) {
					//SO = 3
					GameManager.lastBlanco = 3;
				}  else if (col.transform.position.x > 0 && col.transform.position.z < 0) {
					//SE = 4
					GameManager.lastBlanco = 4;
				}
				print ("ultima posicion blanco:"+ GameManager.lastBlanco);
				break;
		}

	}
}