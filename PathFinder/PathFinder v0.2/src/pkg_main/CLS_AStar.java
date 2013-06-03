package pkg_main;

import java.util.ArrayList;
import java.util.Collections;

public class CLS_AStar {

	private CLS_Nodo tNodoOrigen;
	private CLS_Nodo tNodoDestino;
	private CLS_Nodo tNodoActual;
	private ArrayList<CLS_Nodo> tListaCiudad = new ArrayList<CLS_Nodo>();
	private ArrayList<CLS_Nodo> tListaEliminados = new ArrayList<CLS_Nodo>();
	private CLS_ListaNodos tListaNodos = new CLS_ListaNodos();

	public CLS_AStar(ArrayList<CLS_Nodo> tListaCiudad, int iOrigen, int iDestino) {
		super();
		
		this.tListaCiudad = tListaCiudad;
		this.tNodoOrigen = this.tListaCiudad.get(iOrigen);
		this.tNodoDestino = this.tListaCiudad.get(iDestino);
	}

	public void calcularRuta() {
		float fCosteFijo = 0;
		
		// Cogemos el nodo origen como nodo actual
		this.tNodoActual = this.tNodoOrigen;
		// Seteamos el coste a 0
		this.tNodoActual.setCoste(0);
		// Añadimos a la lista de nodos
		this.tListaNodos.añadirNodo(this.tNodoActual);
		
		// Mientras la lista no esta vacia
		while (tListaNodos.getSize() != 0) {
			// Ordenamos la lista
			Collections.sort(this.tListaNodos.getListaNodos());
			// Cogemos el primer elemento de la lista
			this.tNodoActual = this.tListaNodos.getPrimerNodo();
			// Imprimimos la lista ordenada
			printLista();
			
			// Si el nodo actual es el destino
			if (this.tNodoActual == this.tNodoDestino) {
				printResultado();
				break;
			}
			
			System.out.println(" => " + this.tNodoActual.getNombre() + " no es el destino");
			// Eliminamos el nodo actual de la lista
			tListaNodos.eliminarNodo(this.tNodoActual);
			
			System.out.println(" => " + this.tNodoActual.getNombre() + " eliminado de la lista \n");
			// Añadimo el nodo a la lista de eliminados
			tListaEliminados.add(this.tNodoActual);

			System.out.println("Generando los hijos de: " + this.tNodoActual.getNombre() + " - " + this.tNodoActual.getCoste());

			// Recorremos los hijos del nodo actual
			for (int i = 0; i < this.tNodoActual.getHijos().size(); i++) {
				// Cogemos el hijo actual
				CLS_Nodo tNodoHijo = this.tNodoActual.getHijos().get(i);
				
				// Comprobamos si el hijo ya existe en la lista de eliminados
				if (existeNodoEliminados(tNodoHijo) == true) {
					continue;
				}

				// Lo identificamos como padre
				tNodoHijo = getNodoAsPadre(tNodoHijo);

				if (tNodoHijo == null)
					continue;

				// Cogemos el coste fijo del padre y le sumamos al coste del hijo
				fCosteFijo = this.tNodoActual.getCoste() + this.tNodoActual.getHijos().get(i).getCoste();	
				
				System.out.println(" - Hijo: " + tNodoHijo.getNombre() +  " => Distancia: " + this.tNodoActual.getHijos().get(i).getCoste());
				
				CLS_Nodo tNodoAux = this.tNodoActual.getHijos().get(i);
				tNodoAux.setCoste(fCosteFijo);
				// Verificamos si existen duplicados, o rutas mas cortas
				int iRet = existeOptimo(tNodoAux);
				
				if (iRet == -2) { // Si no existe ningun nodo con el mismo nombre
					// Aplicamos el coste final
					tNodoHijo.setCoste(fCosteFijo);
					// Asignamos al padre
					tNodoHijo.setNodoPadre(this.tNodoActual);
					// Añadimos a la lista
					this.tListaNodos.añadirNodo(tNodoHijo);
				} else if (iRet >= 0) { // Si existe algun nodo con distancia mayor
					this.tListaNodos.setNodo(iRet, tNodoAux);
				}
			}
			
			System.out.println();
		}
	}

	private CLS_Nodo getNodoAsPadre(CLS_Nodo tNodoHijo) {
		for (int i = 0; i < this.tListaCiudad.size(); i++) {
			if ((this.tListaCiudad.get(i).getCoste() == -1) && (this.tListaCiudad.get(i).getNombre().equals(tNodoHijo.getNombre()))) {
				return this.tListaCiudad.get(i);
			}
		}

		return null;
	}

	private Boolean existeNodoEliminados(CLS_Nodo tNodo) {
		for (int i = 0; i < this.tListaEliminados.size(); i++) {
			if (this.tListaEliminados.get(i).getNombre().equals(tNodo.getNombre())) {
				return true;
			}
		}

		return false;
	}
	
	private int existeOptimo(CLS_Nodo tNodo) {
		for (int i = 0; i < this.tListaNodos.getSize(); i++) {
			if (this.tListaNodos.getNodo(i).getNombre().equals(tNodo.getNombre())) {
				if (this.tListaNodos.getNodo(i).getCoste() <= tNodo.getCoste()) {
					return -1;
				}
				
				return i;
			} 
		}
		
		return -2;
	}
	
	private String getRutaCompleta(CLS_Nodo tNodo) {
		String sRet = "";
		ArrayList<CLS_Nodo> tListaAux = new ArrayList<CLS_Nodo>();

		while (tNodo.getNodoPadre() != null) {
			tListaAux.add(tNodo);
			tNodo = tNodo.getNodoPadre();
		}
		
		Collections.reverse(tListaAux);
		sRet = this.tNodoOrigen.getNombre();
		
		for (int i = 0; i < tListaAux.size(); i++) {
			sRet += " => " + tListaAux.get(i).getNombre();
		}

		return sRet;
	}
	
	private void printLista() {
		System.out.println("Lista Ordenada: ");

		for (int i = 0; i < this.tListaNodos.getListaNodos().size(); i++) {
			System.out.println(" + " + this.tListaNodos.getListaNodos().get(i).getNombre() + " - " + 
										this.tListaNodos.getListaNodos().get(i).getCoste());
		}
		
		System.out.println();
	}
	
	private void printResultado() {
		System.out.println(" => " + this.tNodoDestino.getNombre() + " es el destino \n");
		System.out.println("==> BUSQUEDA FINALIZADA <== \n");
		System.out.println("Origen: " + this.tNodoOrigen.getNombre());
		System.out.println("Destino: " + this.tNodoActual.getNombre());
		System.out.println("Distancia: " + this.tNodoActual.getCoste() + " Km(s)");
		System.out.println("Ruta Completa: " + getRutaCompleta(this.tNodoActual));
	}
}
