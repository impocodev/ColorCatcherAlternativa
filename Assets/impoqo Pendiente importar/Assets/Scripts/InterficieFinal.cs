using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterficieFinal : MonoBehaviour {

    public Text textThrown;
    public Text textDestroyed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        textThrown.text = "" + GameManager.cubosLanzados;
        textDestroyed.text = "" + GameManager.cubosDestruidos;
    }

    public void InicioJuego ()    {
		SceneManager.LoadScene ("Inicio");
    }
}
