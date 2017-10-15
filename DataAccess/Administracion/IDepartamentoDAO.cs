using Entidades.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Administracion
{
    public interface IDepartamentoDAO
    {

        List<Departamento> getAllDepartamento(ref string mensaje);

        Departamento getDepartamento(int id, ref string mensaje);

        void insertDepartamento(Departamento departamento, string usuario, ref string mensaje);

        void updateDepartamento(Departamento departamento, string usuario, ref string mensaje);
    }
}
