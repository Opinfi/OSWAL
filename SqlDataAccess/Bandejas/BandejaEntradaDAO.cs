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
    public class BandejaEntradaDAO : IBandejaEntradaDAO
    {
        ConsultasSQL sql = new ConsultasSQL();
        public List<BandejaEntrada> getAllBandejaEntrada(ref string mensaje)
        {
            List<BandejaEntrada> ProcesosEntrada = new List<BandejaEntrada>();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getListBandejaEntrada";

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    ProcesosEntrada.Add(BandejaEntrada.CreateBandejaEntradaFromDataRecord(reader));
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

            return ProcesosEntrada;
        }

        public BandejaEntrada getBandejaEntrada(int id, ref string mensaje)
        {
            BandejaEntrada procesosEntrada = new BandejaEntrada();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getBandejaEntrada";
            sql.Comando.Parameters.AddWithValue("@IdProceso", id);

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    procesosEntrada = BandejaEntrada.CreateBandejaEntradaFromDataRecord(reader);
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

            return procesosEntrada;
        }
    }
}
