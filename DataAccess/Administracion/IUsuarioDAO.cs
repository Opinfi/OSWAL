using Entidades.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Administracion
{
    public interface IUsuarioDAO
    {
        List<Usuario> getAllUsuario(ref string mensaje);

        Usuario getUsuario(int id, ref string mensaje);

        void insertUsuario(Usuario usuarios, string usuario, ref string mensaje);

        void updateUsuario(Usuario usuarios, string usuario, ref string mensaje);
    }
}
