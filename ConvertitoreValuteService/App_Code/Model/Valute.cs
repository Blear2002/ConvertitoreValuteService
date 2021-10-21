using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per Valute
/// </summary>
public class Valute
{
    List<Valuta> lista_valute;

    public Valuta val{ get; set; }

    public Valute()
    {
        //Creo la lista ed lo poopolo
        lista_valute = new List<Valuta>();
        lista_valute.Add(new Valuta("EUR", "Euro"));
        lista_valute.Add(new Valuta("USD", "Dollaro Americano "));
        lista_valute.Add(new Valuta("GBP ", "Sterlina Inglese "));
        lista_valute.Add(new Valuta("JPY", "Yen Giapponese "));
        lista_valute.Add(new Valuta("CHF ", "Franco Svizzero "));
        lista_valute.Add(new Valuta("CAD ", "Dollaro Canadese "));
        lista_valute.Add(new Valuta("AUD", "Dollaro Australiano "));
        lista_valute.Add(new Valuta("BTC", "Bitcoin"));
    }
    
    public List<Valuta> getAll()
    {
        return lista_valute;
    }

}