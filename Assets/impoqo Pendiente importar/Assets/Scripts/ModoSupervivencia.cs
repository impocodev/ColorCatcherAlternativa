using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ModoSupervivencia : MonoBehaviour
{
    public GameObject explosion;
    public GameObject esfera = new GameObject();
	public AudioClip puntoAudio;
	TrailRenderer trazo;
	AudioSource sonido;

	void Start(){
		trazo = GetComponent<TrailRenderer> ();
		sonido = GetComponent<AudioSource> ();
	}

    void OnCollisionEnter(Collision col)
    {
        Color colorEsferaActual = esfera.GetComponent<Renderer>().material.color;
        if (colorEsferaActual == Color.white)
        {
            switch (col.gameObject.tag)
            {
				case "Amarillo":
              	 	Destroy(col.gameObject);
            	    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					gameObject.tag = "Amarillo";
					gameObject.GetComponent<Renderer>().material.color = Color.yellow;
					GameManager.Amarillo--;
					scriptShake.shaking = true;
					trazo.material.color = Color.yellow;
					sonido.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
				case "Azul":
					Destroy(col.gameObject);
					Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					gameObject.tag = "Azul";
					gameObject.GetComponent<Renderer>().material.color = Color.cyan;
					GameManager.Azul--;
					trazo.material.color = Color.cyan;
					scriptShake.shaking = true;
					sonido.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
				case "Rojo":
					Destroy(col.gameObject);
					Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					gameObject.tag = "Rojo";
					gameObject.GetComponent<Renderer>().material.color = Color.red;
					GameManager.Rojo--;
					scriptShake.shaking = true;
					trazo.material.color = Color.red;
					sonido.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
				case "Fucsia":
					Destroy(col.gameObject);
					Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					gameObject.tag = "Fucsia";
					gameObject.GetComponent<Renderer>().material.color = Color.magenta;
					GameManager.Fucsia--;
					scriptShake.shaking = true;
					trazo.material.color = Color.magenta;
					sonido.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
				case "Blanco":
					Destroy(col.gameObject);
					Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					gameObject.tag = "Blanco";
					gameObject.GetComponent<Renderer>().material.color = Color.white;
					GameManager.Blanco--;
					scriptShake.shaking = true;
					trazo.material.color = Color.white;
					sonido.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
				case "Verde":
					Destroy(col.gameObject);
					Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					gameObject.tag = "Verde";
					gameObject.GetComponent<Renderer>().material.color = Color.green;
					GameManager.Verde--;
					scriptShake.shaking = true;
					trazo.material.color = Color.green;
					sonido.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
			}
		} else {
			if (col.gameObject.tag != gameObject.tag && col.gameObject.tag != "Suelo") {
				if (col.gameObject.tag != "Blanco") {
						SceneManager.LoadScene("Final");
				}
			}
			if (col.gameObject.tag == "Amarillo" && gameObject.tag == "Amarillo") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Amarillo--;
				scriptShake.shaking = true;
				trazo.material.color = Color.yellow;
				sonido.PlayOneShot (puntoAudio, 1F);//Rubén
			}
			if (col.gameObject.tag == "Azul" && gameObject.tag == "Azul") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Azul--;
				scriptShake.shaking = true;
				trazo.material.color = Color.cyan;
				sonido.PlayOneShot (puntoAudio, 1F);//Rubén
			}
			if (col.gameObject.tag == "Verde" && gameObject.tag == "Verde") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Verde--;
				scriptShake.shaking = true;
				trazo.material.color = Color.green;
				sonido.PlayOneShot (puntoAudio, 1F);//Rubén
			}
			if (col.gameObject.tag == "Fucsia" && gameObject.tag == "Fucsia") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Fucsia--;
				scriptShake.shaking = true;
				trazo.material.color = Color.magenta;
				sonido.PlayOneShot (puntoAudio, 1F);//Rubén
			}
			if (col.gameObject.tag == "Rojo" && gameObject.tag == "Rojo") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Rojo--;
				scriptShake.shaking = true;
				trazo.material.color = Color.red;
				sonido.PlayOneShot (puntoAudio, 1F);//Rubén
			}
			if (col.gameObject.tag == "Blanco" && gameObject.tag == "Blanco") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				gameObject.GetComponent<Renderer>().material.color = Color.white;
				GameManager.cubosDestruidos++;
				GameManager.Blanco--;
				scriptShake.shaking = true;
				trazo.material.color = Color.white;
				sonido.PlayOneShot (puntoAudio, 1F);//Rubén
			}
		}   
    }
}