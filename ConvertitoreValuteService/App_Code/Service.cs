using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
// NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service" nel codice, nel file svc e nel file di configurazione contemporaneamente.
public class Service : IService
{
    Valute model = new Valute();
    public List<Valuta> valute
    {
        get; set;
    }
    public string GetData(int value)
    {
        throw new NotImplementedException();
    }
    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        throw new NotImplementedException();
    }
    public List<Valuta> GetValute()
    {
        return model.getAll();
        
    }
    public double converti(double importo, string da, string a)
    {
        double risultato = 0;
        Valuta prima = new Valuta("","");
        Valuta dopo = new Valuta("", "");
        valute = new List<Valuta>();
        valute = new List<Valuta>(model.getAll());
            foreach (Valuta V in valute)
            {
                if (V.Sigla == da)
                {
                prima = new Valuta(V.Sigla,V.Nome);
                }
            }
        
        foreach(Valuta V in valute)
        {
            if (V.Sigla == a)
            {
                dopo = new Valuta(V.Sigla, V.Nome);
            }
        }

        return risultato = importo * (dopo.Valore/prima.Valore);
    }
}
