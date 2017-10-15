using Entidades.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Administracion
{
    public interface ITipoCorrespondenciaDAO
    {
        List<TipoCorrespondencia> getAllTipoCorrespondencia(ref string mensaje);

        TipoCorrespondencia getTipoCorrespondencia(int id, ref string mensaje);

        void insertTipoCorrespondencia(TipoCorrespondencia tipoCorrespondencia, string usuario, ref string mensaje);

        void updateTipoCorrespondencia(TipoCorrespondencia tipoCorrespondencia, string usuario, ref string mensaje);
    }
}
