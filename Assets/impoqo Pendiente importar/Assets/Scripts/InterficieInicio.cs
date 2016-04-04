using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InterficieInicio : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameManager.cubosDestruidos = 0;
        GameManager.cubosLanzados = 0;
        GameManager.tiempoTranscurrido = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Contrareloj ()    {
		SceneManager.LoadScene ("GamePlay");
    }

//    public void Supervivencia()
//    {
//		SceneManager.LoadScene ("Modo_Supervivencia");
//    }
}
