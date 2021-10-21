using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per Valuta
/// </summary>

[DataContract] 
public class Valuta
{
    [DataMember]
    public string Sigla { get; set; }
    
    [DataMember]
    public string  Nome { get; set; }
    
    [DataMember]
    public double Valore { get; set; }

    public Valuta(string sigla,string nome)
    {
        Sigla = sigla;
        Nome = nome;
        switch(sigla)
        {
            case "EUR":
                Valore = 1;
                break;

            case "BTC":
                Valore = 0.000017;
                break;

            case "USD":
                Valore = 1.1655;
                break;

            case "GBP":
                Valore = 0.8427;
                break;

            case "JPY":
                Valore = 133.12;
                break;

            case "CHF":
                Valore = 1.0710;
                break;

            case "CAD":
                Valore = 1.4357;
                break;

            case "AUD":
                Valore = 1.5495;
                break;

            default:
                Valore = 0;
                break;
        }
    }
}