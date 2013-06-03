package pkg_main;

import java.util.ArrayList;

public class CLS_Nodo implements Comparable<CLS_Nodo> {

	private String sNombre;
	private float fCoste;
	private CLS_Nodo tNodoPadre;
	private ArrayList<CLS_Nodo> tHijos;

	public CLS_Nodo() {
		super();
	}

	public CLS_Nodo(String sNombre, float fCoste, CLS_Nodo tNodoPadre, ArrayList<CLS_Nodo> tHijos) {
		super();
		this.sNombre = sNombre;
		this.fCoste = fCoste;
		this.tHijos = new ArrayList<CLS_Nodo>();
	}
	
	public String getNombre() {
		return sNombre;
	}

	public void setNombre(String sNombre) {
		this.sNombre = sNombre;
	}

	public float getCoste() {
		return fCoste;
	}

	public void setCoste(float fCoste) {
		this.fCoste = fCoste;
	}

	public CLS_Nodo getNodoPadre() {
		return this.tNodoPadre;
	}

	public void setNodoPadre(CLS_Nodo tNodoPadre) {
		this.tNodoPadre = tNodoPadre;
	}
	
	public ArrayList<CLS_Nodo> getHijos() {
		return this.tHijos;
	}

	public void setHijos(ArrayList<CLS_Nodo> tHijos) {
		this.tHijos = tHijos;
	}
	
	public void añadirNodoHijo(CLS_Nodo tNodoHijo) {
		this.tHijos.add(tNodoHijo);
	}
	
	public void eliminarNodoHijo(int iPosicion) {
		this.tHijos.remove(iPosicion);
	}
	
	@Override
	public int compareTo(CLS_Nodo tNodo) {
		return (int) this.fCoste - (int) tNodo.getCoste();
	}
}
