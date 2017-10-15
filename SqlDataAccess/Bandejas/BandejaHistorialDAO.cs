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
    public class BandejaHistorialDAO : IBandejaHistorialDAO
    {
        ConsultasSQL sql = new ConsultasSQL();
        public List<BandejaHistorial> getAllBandejaHistorial(ref string mensaje)
        {
            List<BandejaHistorial> procesosHistorial = new List<BandejaHistorial>();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getListBandejaHistorial";

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    procesosHistorial.Add(BandejaHistorial.CreateBandejaHistorialFromDataRecord(reader));
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

            return procesosHistorial;
        }

        public BandejaHistorial getBandejaHistorial(int id, ref string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
