using DataAccess.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Administracion;
using SqlDataAccess.Utils;
using System.Data;

namespace SqlDataAccess.Administracion
{
    public class DepartamentoDAO : IDepartamentoDAO
    {
        ConsultasSQL sql = new ConsultasSQL();

        public List<Departamento> getAllDepartamento(ref string mensaje)
        {
            List<Departamento> departamentos = new List<Departamento>();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getListDepartamentos";

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    departamentos.Add(Departamento.CreateDepartamentoFromDataRecord(reader));
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                sql.CerrarConexion();
            }

            return departamentos;
        }

        public Departamento getDepartamento(int id, ref string mensaje)
        {
            throw new NotImplementedException();
        }

        public void insertDepartamento(Departamento departamento, string usuario, ref string mensaje)
        {
            throw new NotImplementedException();
        }

        public void updateDepartamento(Departamento departamento, string usuario, ref string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
