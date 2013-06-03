package pkg_main;

import java.util.ArrayList;

public class CLS_ListaNodos {
	
	private ArrayList<CLS_Nodo> tListaNodos = new ArrayList<CLS_Nodo>();
	
	public void añadirNodo(CLS_Nodo tNodo) {
		this.tListaNodos.add(tNodo);
	}
	
	public void eliminarNodo(CLS_Nodo tNodo) {
		this.tListaNodos.remove(tNodo);
	}
	
	public CLS_Nodo getNodo(int iIndex) {
		return this.tListaNodos.get(iIndex);
	}
	
	public void setNodo(int iIndex, CLS_Nodo tNodo) {
		this.tListaNodos.set(iIndex, tNodo);
	}
	
	public ArrayList<CLS_Nodo> getListaNodos() {
		return this.tListaNodos;
	}
	
	public int getSize() {
		return this.tListaNodos.size();
	}
	
	public CLS_Nodo getPrimerNodo() {
		return this.tListaNodos.get(0);
	}
	
	public CLS_Nodo getUltimoNodo() {
		return this.tListaNodos.get(this.tListaNodos.size() -1);
	}
}
