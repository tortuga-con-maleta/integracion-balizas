package modulobaliza.ws;
import javax.jws.*;

@WebService (serviceName="BalizaWS")
public class BalizaWS {
    @WebMethod(operationName="holaMundo")
    public String holaMundo()
    {        
        return "hola mundo";
    }    
}
