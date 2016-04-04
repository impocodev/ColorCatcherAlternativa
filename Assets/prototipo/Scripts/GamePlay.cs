using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//script de control del juego 
public class GamePlay : MonoBehaviour {

	//declarem els objectes.
	public GameObject baldosa;
	//mides de la sala.
	public int ancho = 10;
	public int largo = 10;

	public float explotan = 5.0f;

	static public float cuentaAtras;


	public float tiempoEntreBombas = 2.0f;
	private bool activarBombas = true;



	void Awake() {
	//	Instantiate (oriol, new Vector3 (ancho/2, 0, largo/2), Quaternion.identity);

		for (int z = 0; z < largo; z++ ) {
			for (int x = 0; x < ancho; x++) {
				Instantiate (baldosa, new Vector3 (x, 0, z), Quaternion.identity);
			}
		}
		cuentaAtras = explotan;
	}

	void Start () {
		gameObject.transform.position = new Vector3(Random.Range(0, ancho), 5.0f, Random.Range(0, largo));
		StartCoroutine(tirarBombas());
	}


	//	// simplement per reiniciar partida en protos.
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene ("GamePlay");
		}
	}
	
	IEnumerator tirarBombas()
		{
	
			// inici del delay.
			yield return new WaitForSeconds(0);
	
			while(activarBombas) {
				RaycastHit hit;
				Ray rayo = new Ray(transform.position, Vector3.down);
	
				if (Physics.Raycast (rayo, out hit, 6.0f)) {
					if (hit.collider.tag == "baldosa") {
					Instantiate (ControlCubos.listaCubos [Random.Range (0, ControlCubos.listaCubos.Count)], transform.position, Quaternion.identity);
					GameManager.cubosLanzados++;
					gameObject.transform.position = new Vector3(Random.Range(0, ancho), 5.0f, Random.Range(0, largo));
					ControlCubos.listaCubos.Clear();//oriol. la lista de cubos se vacia.
					ControlCubos.cubosEnable ();
					} else {
						gameObject.transform.position = new Vector3(Random.Range(0, ancho), 5.0f, Random.Range(0, largo));
						yield return new WaitForSeconds(0);
					}
				} else {
					gameObject.transform.position = new Vector3(Random.Range(0, ancho), 5.0f, Random.Range(0, largo));
					yield return new WaitForSeconds(0);
				}
				yield return new WaitForSeconds(tiempoEntreBombas);
			}
		}
}