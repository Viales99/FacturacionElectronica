using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Business
{
    public class CoordinardorDeUsuarios
    {

        public string ObtenerUsuario(string id)
        {
            DataAccess.GestorDeUsuarios elGestor = new DataAccess.GestorDeUsuarios();
            List<FacturaElectronica.Model.AspNetUsers> laListaDeUsuarios = new List<Model.AspNetUsers>();
            laListaDeUsuarios = elGestor.ObtenerUsuario(id);

            foreach (var elUsuario in laListaDeUsuarios)
            {
                if (elUsuario.Id.Equals(id))
                {
                    return elUsuario.UserName;
                }
            }
            return null;
        }
    }
}
