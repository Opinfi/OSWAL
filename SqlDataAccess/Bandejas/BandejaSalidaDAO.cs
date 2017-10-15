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
    public class BandejaSalidaDAO : IBandejaSalidaDAO
    {
        ConsultasSQL sql = new ConsultasSQL();
        public List<BandejaSalida> getAllBandejaSalida(ref string mensaje)
        {
            List<BandejaSalida> ProcesosSalida = new List<BandejaSalida>();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getListBandejaSalida";

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    ProcesosSalida.Add(BandejaSalida.CreateProcesoFromDataRecord(reader));
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

            return ProcesosSalida;
        }

        public BandejaSalida getBandejaSalida(int id, ref string mensaje)
        {
            BandejaSalida procesoSalida = new BandejaSalida();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getBandejaSalida";
            sql.Comando.Parameters.AddWithValue("@IdProceso", id);

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    procesoSalida = BandejaSalida.CreateProcesoFromDataRecord(reader);
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

            return procesoSalida;
        }
    }
}
