using Entidades.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Administracion
{
    public interface IEstadoDAO
    {
        List<Estado> getAllEstado(ref string mensaje);

        Estado getEstado(int id, ref string mensaje);        

        void insertEstado(Estado estado, string usuario, ref string mensaje);

        void updateEstado(Estado estado, string usuario, ref string mensaje);
        
    }
}
