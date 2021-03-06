﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WSpromociones
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WSpromociones : System.Web.Services.WebService {

    public WSpromociones () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string registrarMovimientoUsuario(string idCliente, string idZona) {
        Console.WriteLine("entrando en registrarMovimientoUsuario");
        BalizaReference.BalizaWSClient balizaWSClient = new BalizaReference.BalizaWSClient();
        balizaWSClient.enviarPromocion(idCliente, "Este es el texto de la promoción");
        
        return "Promocion:este es el mensaje :D";
    }

    [WebMethod]
    public bool wsPuerta(string idCliente, string idPuerta)
    {
        
        return true;
    }
    
}
