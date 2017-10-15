using DataAccess.Bandejas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Bandejas;
using SqlDataAccess.Utils;
using System.Data;

namespace SqlDataAccess.Bandejas
{
    public class BandejaEliminacionDAO : IBandejaEliminacionDAO
    {
        ConsultasSQL sql = new ConsultasSQL();
        public List<BandejaEliminacion> getAllBandejaEliminacion(ref string mensaje)
        {
            List<BandejaEliminacion> procesosEliminacion = new List<BandejaEliminacion>();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getListBandejaEliminados";

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    procesosEliminacion.Add(BandejaEliminacion.CreateBandejaEliminacionFromDataRecord(reader));
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

            return procesosEliminacion;
        }

        public BandejaEliminacion getBandejaEliminacion(int id, ref string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
