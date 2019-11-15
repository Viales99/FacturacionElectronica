using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace FacturaElectronica.DataAccess
{
    public class GestorDeProductos
    {
        public List<Model.Producto> ListarProductos()
        {
            var db = new Contexto();

            var resultado = db.Producto.ToList();

            return resultado.ToList();

        }

        public void AgregarProducto(Model.Producto producto)
        {
            var db = new Contexto();
            db.Producto.Add(producto);
            db.Entry(producto).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }

        public Model.Producto ConsultarProducto(string codigo)
        {

            var db = new Contexto();
            var resultado = db.Producto.Find(codigo);

            return resultado;
        }

        public void ActualizarProducto(Model.Producto producto)
        {
            var valorBd = ConsultarProducto(producto.CodigoProducto);
            var db = new Contexto();

            valorBd.Detalle = producto.Detalle;
            valorBd.Descuento = producto.Descuento;
            valorBd.Impuesto = producto.Impuesto;
            valorBd.PrecioUnitario = producto.PrecioUnitario;

            db.Entry(valorBd).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }

        public void EliminarProducto(string codigo)
        {
            var db = new Contexto();
            var valorBd = ConsultarProducto(codigo);
          
            db.Entry(valorBd).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

      

    }
}
