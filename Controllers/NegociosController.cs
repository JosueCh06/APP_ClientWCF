using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using APP_ClientWCF.ReferenciasNegocios;

namespace APP_ClientWCF.Controllers
{
    public class NegociosController : Controller
    {
        // GET: Negocios
        ServicioNegociosClient dbServicio = new ServicioNegociosClient();
        public ActionResult listarClientes()
        {
            return View(dbServicio.Clientes().ToList());
        }

        public ActionResult listarClientesXNombres(string nombre = null)
        {
            if (nombre == null) nombre = string.Empty;
            ViewBag.nombre = nombre;
            return View(dbServicio.ClienteXNombre(nombre).ToList());
        }
    }
}