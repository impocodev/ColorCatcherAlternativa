using UnityEngine;
using System.Collections;

public class MovimientoEsfera : MonoBehaviour
{

    public float forceValue;
    private Rigidbody fisica;

	float speed = 1000.0f;
    // Función que se ejecuta en el inicio.
    void Start(){
        fisica = GetComponent<Rigidbody>();
		Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    void FixedUpdate(){
        fisica.AddForce(new Vector3(Input.GetAxis("Horizontal"),
                                        0,
                                        Input.GetAxis("Vertical")) * forceValue);
		float movimientoX = Input.acceleration.x;
		float movimientoY = Input.acceleration.y;

		Vector3 movimineto = new Vector3 (movimientoX, 0.0f, movimientoY);
		GetComponent<Rigidbody> ().AddForce (movimineto * speed * Time.deltaTime);
	
//		if (gameObject.transform.position.x < 010 && gameObject.transform.position.x > -1) {
//			//N0 = 1
//			fisica.AddForce = 0;
//			GameManager.posicionBola = 1;
//		} else if (gameObject.transform.position.z > 10 && gameObject.transform.position.z > -1) {
//			//NE = 2
//			fisica.AddForce = 0;
//			GameManager.posicionBola = 2;
//		}
//		} else if (gameObject.transform.position.x < 0 && gameObject.transform.position.z < 0) {
//			//SO = 3
//			GameManager.posicionBola = 3;
//		} else if (gameObject.transform.position.x > 0 && gameObject.transform.position.z < 0) {
//			//SE = 4
//			GameManager.posicionBola = 4;
//		}
    }
}
