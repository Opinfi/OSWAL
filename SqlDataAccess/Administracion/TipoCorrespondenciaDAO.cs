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
    public class TipoCorrespondenciaDAO : ITipoCorrespondenciaDAO
    {

        ConsultasSQL sql = new ConsultasSQL();
        public List<TipoCorrespondencia> getAllTipoCorrespondencia(ref string mensaje)
        {
            List<TipoCorrespondencia> tipoCorrespondencia = new List<TipoCorrespondencia>();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getListTipoCorrespondencia";

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    tipoCorrespondencia.Add(TipoCorrespondencia.CreateTipoCorrespondenciaFromDataRecord(reader));
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

            return tipoCorrespondencia;


            
        }

        public TipoCorrespondencia getTipoCorrespondencia(int id, ref string mensaje)
        {
            throw new NotImplementedException();
        }

        public void insertTipoCorrespondencia(TipoCorrespondencia tipoCorrespondencia, string usuario, ref string mensaje)
        {
            throw new NotImplementedException();
        }

        public void updateTipoCorrespondencia(TipoCorrespondencia tipoCorrespondencia, string usuario, ref string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
