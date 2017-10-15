using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Proceso
{
    public interface IProcesoDAO
    {
        List<Entidades.Proceso.Proceso> getAllProceso(ref string mensaje);

        Entidades.Proceso.Proceso getProceso(int id, ref string mensaje);

        void insertProceso(Entidades.Proceso.Proceso proceso, string usuario, ref string mensaje);

        void updateProceso(Entidades.Proceso.Proceso proceso, string usuario, ref string mensaje);
    }
}
