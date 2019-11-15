using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;
using System.Text;


namespace FacturaElectronica.UI.Controllers
{
    public class ProductosController : Controller
    {
       
        public ActionResult ListaDeProductos()
        {

            Business.CoordinadorDeProductos RealizaLaOperacionDe = new Business.CoordinadorDeProductos();

            var laListaDeProductos = RealizaLaOperacionDe.ListarProductos();

            return View(laListaDeProductos);

        }

        public ActionResult DetallesProducto(int id)
        {

            return View();
        }

        
        public ActionResult CrearProducto()
        {
            return View();
        }

     
        [HttpPost]
        public ActionResult CrearProducto(Model.Producto producto)
        {
            try
            {
                Business.CoordinadorDeProductos RealizaLaOperacionDe = new Business.CoordinadorDeProductos();

                RealizaLaOperacionDe.AgregarProducto(producto);

                return RedirectToAction("ListaDeProductos");
            }
            catch {

                return View();
            }
        }

        public ActionResult EditarProducto(string codigo)
        {
            Business.CoordinadorDeProductos RealizaLaOperacionDe = new Business.CoordinadorDeProductos();

            var BuscarProducto = RealizaLaOperacionDe.ConsultarProducto(codigo);

            return View(BuscarProducto);
        }

        [HttpPost]
        public ActionResult EditarProducto(Model.Producto producto)
        {
            try
            {
                Business.CoordinadorDeProductos RealizaLaOperacionDe = new Business.CoordinadorDeProductos();

                RealizaLaOperacionDe.ActualizarProducto(producto);

                return RedirectToAction("ListaDeProductos");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EliminarProducto(string codigo)
        {
            Business.CoordinadorDeProductos RealizaLaOperacionDe = new Business.CoordinadorDeProductos();

            var BuscarProducto = RealizaLaOperacionDe.ConsultarProducto(codigo);

            return View(BuscarProducto);
        }

        [HttpPost]
        public ActionResult EliminarProducto(string codigo, Model.Producto producto)
        {
            try
            {
                Business.CoordinadorDeProductos RealizaLaOperacionDe = new Business.CoordinadorDeProductos();

                RealizaLaOperacionDe.EliminarProducto(codigo);

                return RedirectToAction("ListaDeProductos");
            }
            catch {

                return View();
            }
        }
    }
}
