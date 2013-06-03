package pkg_main;

import java.util.ArrayList;

public class CLS_PathFinder {
	
	private String sMapa;
	
	public CLS_PathFinder(String sMapa) {
		this.sMapa = sMapa;
	}
	
	public ArrayList<CLS_Nodo> cargarMapa() {
		ArrayList<CLS_Nodo> tRet = new ArrayList<CLS_Nodo>();
		String[] sData = CLS_Funciones.readFile(this.sMapa);
		
		// Recorremos el array
		for (int i = 0; i < sData.length; i++) {
			String[] sCiudad = sData[i].split(";");
			// Cogemos el nombre del padre
			CLS_Nodo tNodoPadre = new CLS_Nodo(sCiudad[0], -1, null, null);
			// Recorremos el resto de las ciudades
			for (int x = 1; x < sCiudad.length; x++) {
				String sNombre = sCiudad[x].substring(0, sCiudad[x].indexOf("("));
				String sCoste = sCiudad[x].substring(sCiudad[x].indexOf("(") + 1, sCiudad[x].indexOf(")"));

				if (Integer.parseInt(sCoste) > 0) {
					CLS_Nodo tNodoHijo = new CLS_Nodo(sNombre, Integer.parseInt(sCoste), null, null);
					tNodoPadre.añadirNodoHijo(tNodoHijo);
				}
			}

			tRet.add(tNodoPadre);
		}
		
		return tRet;
	}
}
