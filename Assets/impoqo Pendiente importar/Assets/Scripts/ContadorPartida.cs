using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ContadorPartida : MonoBehaviour
{

    public Text Cubos_Lanzados;
    public Text Cubos_Destruidos;
	public Text Tiempo_Restante;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Cubos_Lanzados.text = "" + GameManager.cubosLanzados;
        Cubos_Destruidos.text = "" + GameManager.cubosDestruidos;
		Tiempo_Restante.text = "" + GameManager.tiempoTranscurrido;
    }
}