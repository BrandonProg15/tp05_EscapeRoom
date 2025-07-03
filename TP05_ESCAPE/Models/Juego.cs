
namespace TP05_ESCAPE.Models;

public class Juego

{
    public bool EsCodigo {get ; set;}
    public int nroSala {get; set;} = 1; 

    public List<string> CodigosCorrectos = new List<string>() ;

    public Juego()
    {
        CodigosCorrectos.Add("123"); 
        CodigosCorrectos.Add("flor"); 
        CodigosCorrectos.Add("desactivar");
        CodigosCorrectos.Add("codigo");
    }
    public void ArriesgarCodigo(string respuesta)
    {
        int CodigoCorrecto = 0;
        switch (nroSala)
        {
            case 1:
                CodigoCorrecto = 0;
                break;
            case 2:
                CodigoCorrecto = 1;
                break;
            case 3:
                CodigoCorrecto = 2;
                break;
            case 4: 
                CodigoCorrecto = 3; 
                break; 
        }
        if (respuesta == CodigosCorrectos[CodigoCorrecto])
        {
          nroSala++;
        }
    }
}