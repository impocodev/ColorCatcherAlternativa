public static class GameManager
{

   public static int cubosLanzados = 0;
    public static int cubosDestruidos = 0;
	public static float tiempoTranscurrido = 60.0f;

	//oriol. control de total de cubos blancos.
	static public int full = 3;

	//oriol. marca habilitacion para lista cubos.
	static public bool enableRojo = true;
	static public bool enableAmarillo = true;
	static public bool enableAzul = true;
	static public bool enableFucsia = true;
	static public bool enableVerde = true;
	static public bool enableBlanco = true;

	//oriol. contador cubos en juego.
	static public int Rojo = 0;
	static public int Amarillo = 0;
	static public int Azul = 0;
	static public int Fucsia = 0;
	static public int Verde = 0;
	static public int Blanco;

	//oriol. marca cuadrante, NO=1 , NE=2 , SO=3 , SE=4
	static public int lastRojo = 0;
	static public int lastAmarillo = 0;
	static public int lastAzul = 0;
	static public int lastFucsia = 0;
	static public int lastVerde = 0;
	static public int lastBlanco = 0;

	//oriol. posicion del lanzador.
	static public int posicion = 0;

	//oriol. posicion bola.
	static public int posicionBola = 0;


}

