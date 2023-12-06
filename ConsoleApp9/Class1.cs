using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Class1
    {
            public class Utente
            {
                public string Cognome { get; set; }
                public string Nome { get; set; }
                public string Email { get; set; }
                public string Password { get; set; }
                public string RecapitoTelefonico { get; set; }
            }

            public class Documento
            {
                public string CodiceIdentificativo { get; set; }
                public string Titolo { get; set; }
                public int Anno { get; set; }
                public string Settore { get; set; }
                public string Stato { get; set; }
                public string Scaffale { get; set; }
                public List<Autore> Autori { get; set; }
            }

            public class Autore
            {
                public string Cognome { get; set; }
                public string Nome { get; set; }
            }

            public class Libro : Documento
            {
                public int NumeroPagine { get; set; }
            }

            public class DVD : Documento
            {
                public int Durata { get; set; }
            }

            public class Prestito
            {
                public string NumeroProgressivo { get; set; }
                public DateTime Dal { get; set; }
                public DateTime Al { get; set; }
                public Documento DocumentoPrestito { get; set; }
            }

            public class Biblioteca
            {
                public List<Utente> DatabaseUtenti { get; set; }
                public List<Documento> Documenti { get; set; }
                public List<Prestito> Prestiti { get; set; }
            }
    }
}

