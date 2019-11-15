using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Business
{
    public class CoordinadorDeProductos
    {

        public List<Model.Producto> ListarProductos()
        {
            List<Model.Producto> ListaDeProductos = new List<Model.Producto>();

            DataAccess.GestorDeProductos RealizaLaOperacionDe = new DataAccess.GestorDeProductos();

            ListaDeProductos = RealizaLaOperacionDe.ListarProductos();

            return ListaDeProductos;
        }

        public void AgregarProducto(Model.Producto producto)
        {
            DataAccess.GestorDeProductos RealizaLaOperacionDe = new DataAccess.GestorDeProductos();

            RealizaLaOperacionDe.AgregarProducto(producto);

        }

        public Model.Producto ConsultarProducto(string codigo)
        {
            DataAccess.GestorDeProductos RealizaLaOperacionDe = new DataAccess.GestorDeProductos();

            return RealizaLaOperacionDe.ConsultarProducto(codigo);

        }

        public void ActualizarProducto(Model.Producto producto)
        {
            DataAccess.GestorDeProductos RealizaLaOperacionDe = new DataAccess.GestorDeProductos();

            RealizaLaOperacionDe.ActualizarProducto(producto);
        }

        public void EliminarProducto(string codigo)
        {
            DataAccess.GestorDeProductos RealizaLaOperacionDe = new DataAccess.GestorDeProductos();

            RealizaLaOperacionDe.EliminarProducto(codigo);

        }

      

    }
}
