using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.DataAccess
{
    public class GestorDeUsuarios
    {
        public List<Model.AspNetUsers> ObtenerUsuario(string id)
        {
            var db = new Contexto();
            var resultado = db.AspNetUsers.Where(elIdDelUsuario => elIdDelUsuario.Id.Equals(id)).ToList();
            
            return resultado;
        }

        public string ObtenerNombreUsuarioAspNet(string usuario)
        {
            var db = new Contexto();

            IQueryable<string> resultado = from c in db.AspNetUsers
                                           where c.Id.Equals(usuario)
                                           select c.UserName;

            return resultado.FirstOrDefault();
        }
        public string ObtenerIdUsuarioAspNet(string usuario)
        {
            var db = new Contexto();

            IQueryable<string> resultado = from c in db.AspNetUsers
                                           where c.UserName.Equals(usuario)
                                           select c.Id;

            return resultado.FirstOrDefault();
        }

        public string ObtenerCorreoUsuarioAspNet(string usuario)
        {
            var db = new Contexto();

            IQueryable<string> resultado = from c in db.AspNetUsers
                                           where c.UserName.Equals(usuario)
                                           select c.Email;

            return resultado.FirstOrDefault();
        }

    }
}
