package modulobaliza.ws;
import javax.jws.*;

@WebService (serviceName="BalizaWS")
public class BalizaWS {
    @WebMethod(operationName="enviarPromocion")
    public String enviarPromocion(String idCliente, String textoPromocion)
    {        
        return "hola mundo";
    }    
}
