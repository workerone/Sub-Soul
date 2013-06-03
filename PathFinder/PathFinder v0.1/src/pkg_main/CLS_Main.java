/*
Autor: Fakedo0r
Fecha: 02.06.2013
Blog: Sub-Soul.blogspot.com
Correo: Luvel88@gmail.com
*/

package pkg_main;

import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class CLS_Main {

	static ArrayList<CLS_Nodo> tListaCiudades = new ArrayList<CLS_Nodo>();

	public static void main(String[] args) {
		
		InputStreamReader isr = new InputStreamReader(System.in);
		BufferedReader br = new BufferedReader(isr);
		
		String sLine = null;
		
		try {
			System.out.println("Indique el fichero del mapa: ");
			sLine = br.readLine();
			System.out.println();

			if (!new File(sLine).exists()) {
				System.out.println("El mapa indicado no existe!");
				System.exit(0);
			}
			
			CLS_PathFinder tPathFinder = new CLS_PathFinder(sLine);
			tListaCiudades = tPathFinder.cargarMapa();
			 
			for (int i = 0; i < tListaCiudades.size(); i++) {
				System.out.println("+ " + i + " => " + tListaCiudades.get(i).getNombre());
			}

			System.out.println();
			System.out.println("Indique el origen: ");
			String sOrigen = br.readLine();
			
			System.out.println("Indique el destino: ");
			String sDestino = br.readLine();
			System.out.println();
			
			if (!sOrigen.equals("") && !sDestino.equals("")) {
				System.out.println(" ==> SE COMIENZA LA BUSQUEDA <== \n");

				CLS_AStar tStar = new CLS_AStar(tListaCiudades, Integer.parseInt(sOrigen), Integer.parseInt(sDestino));
				tStar.calcularRuta();
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
