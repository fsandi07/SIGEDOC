
//************** Patrón Decorator **************//

//---- Problema de la Canasta de Frutas ----//

// Problema Inicial: Permitir indicar que tipo de frutas tiene la canasta

// Constructor
public CanastaFrutas() {
	// Inicializar la merienda
}

CanastaFrutas canasta = new CanastaFrutas();


// 1- Solución sin el patrón: por medio de constructor y herencia

	public class TipoFruta {
		// Clase Abstracta - Por sí sola no tiene atributos ni métodos implementados
	}
	
   ___ // Se crean Clases Hijas
	|
	|	public class Manzana extends TipoFruta {
	|_		// Constructor y métodos
	|	}
	|
	|	public class Naranja extends TipoFruta {
	|_		// Constructor y métodos
		}

// Constructor que recibe el tipo de fruta
public CanastaFrutas(TipoFruta tipo) {
	// Inicializa la canasta
}

TipoFruta manzana = new Manzana();
CanastaFrutas canasta1 = new CanastaFrutas(manzana);
TipoFruta naranja = new Naranja();
CanastaFrutas canasta2 = new CanastaFrutas(naranja);


// 2- Solución por medio del Decorator Patterm

// Crear el decorador @TipoFruta
@TipoFruta(tipo = "string")

// Utilizar el decorador @TipoFruta

@TipoFruta(tipo = "manzana")
CanastaFrutas canasta1;

@TipoFruta(tipo = "naranja")
CanastaFrutas canasta2;




