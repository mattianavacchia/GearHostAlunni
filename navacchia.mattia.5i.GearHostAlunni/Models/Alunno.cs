using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace navacchia.mattia._5i.GearHostAlunni.Models
{
    public class Alunno
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Immagine { get; set; }
        public string LinkSito { get; set; }

        public Alunno (XElement elemento)
        {
            Nome = elemento.Element("nome").Value;
            Cognome = elemento.Element("cognome").Value;
            LinkSito = elemento.Element("link").Value;
            Immagine = elemento.Element("enclosure").Attribute("url").Value;
        }
    }

    public class Alunni : List<Alunno> { }
}