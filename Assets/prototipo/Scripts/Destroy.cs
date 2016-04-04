using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	
	// es simplement per la optimització del joc,
	//ejecuta la destrucció del objecte als 2 segons (explosion).
	void Start () {
		Destroy (gameObject, 2);
	}
}
