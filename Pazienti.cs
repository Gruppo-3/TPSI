using System;
namespace Libreria.Gruppo3
{
    public class Pazienti
    {
            public string Nome
        { get; set; }
        public string Cognome
        { get; set; }
        public string CF
        { get; set; }
        public string CodicePriorita
        { get; set; }
        public DateTime Data
        { get; set; }
        public Pazienti()
        {

        }

        public Pazienti(string nome, string congome, string cf, string codice)
        {
             Nome = nome;
            Cognome = congome;
            CF = cf;
            CodicePriorita = codice;
            Data = DateTime.Now;
        }
    }
}