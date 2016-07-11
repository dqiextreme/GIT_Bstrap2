using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Transactions;
using Bstrap2.Models;

using System.Web.Mvc;

namespace Bstrap2.Clases
{
public class Badjunto
{
    public int ID { get; set; }
    public string Archivo { get; set; }
    public string Ruta { get; set; }
        
    public Badjunto()
    {
            
    }

        public Badjunto(Models.Adjunto pTicket)
        {
            ID = pTicket.ID;
            Ruta = pTicket.Ruta;
            Archivo = pTicket.Archivo;
        }

        //SELECT MULTIPLES REGISTROS
        public static IEnumerable<Badjunto> all()
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var res = oBdSdcEntidades.Adjunto.ToList().Select(x => new Badjunto(x)).ToList();
                return res;
            }
        }

    }
}

