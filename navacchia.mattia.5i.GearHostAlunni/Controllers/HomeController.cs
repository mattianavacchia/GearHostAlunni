using navacchia.mattia._5i.GearHostAlunni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace navacchia.mattia._5i.GearHostAlunni.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Alunni listaAlunni = new Alunni();

            XElement classe = XElement.Load("http://navach.altervista.org/home.xml");
            IEnumerable<XElement> TuttiGliAlunni = classe.Elements("channel").Elements("item");

            for (int i = 0; i < TuttiGliAlunni.Count(); i++)
            {
                XElement Alunno = TuttiGliAlunni.ElementAt(i);
                Alunno alu = new Alunno(Alunno);
                listaAlunni.Add(alu);
            }

            return View( listaAlunni );
        }
    }
}