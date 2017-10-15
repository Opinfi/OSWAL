using DataAccess.Administracion;
using Entidades.Administracion;
using SqlDataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess.Administracion
{
    public class EstadoDAO : IEstadoDAO
    {
        ConsultasSQL sql = new ConsultasSQL();

        public List<Estado> getAllEstado(ref string mensaje)
        {
            
            List<Estado> estados = new List<Estado>();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getListEstado";

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    estados.Add(Estado.CreateEstadoFromDataRecord(reader));
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

            return estados;
        }

        public Estado getEstado(int id, ref string mensaje)
        {
            Estado estados = new Estado();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getEstado";
            sql.Comando.Parameters.AddWithValue("@idEstado", id);

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    estados = Estado.CreateEstadoFromDataRecord(reader);
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

            return estados;
        }

        public void insertEstado(Estado estados, string usuario, ref string mensaje)
        {
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_insertEstado";
            sql.Comando.Parameters.AddWithValue("@idEstado", estados.idEstado);
            sql.Comando.Parameters.AddWithValue("@idEstadoTipo", estados.idEstadoTipo = (estados.documentos == true)? "DOCUMENTO" : "PROCESO");
            sql.Comando.Parameters.AddWithValue("@codigo", estados.codigo);
            sql.Comando.Parameters.AddWithValue("@observacion", estados.observacion);
            sql.Comando.Parameters.AddWithValue("@nombre", estados.nombre);
            sql.Comando.Parameters.AddWithValue("@proceso", estados.proceso);
            sql.Comando.Parameters.AddWithValue("@documentos", estados.documentos);
            sql.Comando.Parameters.AddWithValue("@Usuario", usuario);

            try
            {
                sql.AbrirConexion();
                sql.EjecutaQuery(ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                sql.CerrarConexion();
            }
        }

        public void updateEstado(Estado estados, string usuario, ref string mensaje)
        {
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_updateEstado";
            sql.Comando.Parameters.AddWithValue("@idEstado", estados.idEstado);
            sql.Comando.Parameters.AddWithValue("@idEstadoTipo", estados.idEstadoTipo = (estados.documentos == true) ? "DOCUMENTO" : "PROCESO");
            sql.Comando.Parameters.AddWithValue("@codigo", estados.codigo);
            sql.Comando.Parameters.AddWithValue("@observacion", estados.observacion);
            sql.Comando.Parameters.AddWithValue("@nombre", estados.nombre);
            sql.Comando.Parameters.AddWithValue("@proceso", estados.proceso);
            sql.Comando.Parameters.AddWithValue("@documentos", estados.documentos);
            sql.Comando.Parameters.AddWithValue("@Usuario", usuario);

            try
            {
                sql.AbrirConexion();
                sql.EjecutaQuery(ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                sql.CerrarConexion();
            }
        }

       
    }
}
