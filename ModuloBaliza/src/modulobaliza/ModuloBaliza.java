/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modulobaliza;

/**
 *
 * @author cetecom
 */
public class ModuloBaliza {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        WSpromociones ws = new WSpromociones();
        String idCliente = "USERNAME BACAN";
        String idZona = "ZONA G";
        String result = ws.getWSpromocionesSoap().registrarMovimientoUsuario(idCliente, idZona);
        System.out.println(result);
    }
    
}
