using DataAccess.Proceso;
using Entidades.Administracion;
using Entidades.Proceso;
using SqlDataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccess.Proceso
{
    public class ProcesoDAO : IProcesoDAO
    {
        ConsultasSQL sql = new ConsultasSQL();

        public List<Entidades.Proceso.Proceso> getAllProceso(ref string mensaje)
        {
            List<Entidades.Proceso.Proceso> procesos = new List<Entidades.Proceso.Proceso>();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getListProceso";

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    procesos.Add(Entidades.Proceso.Proceso.CreateProcesoFromDataRecord(reader));
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

            return procesos;
        }


        public Entidades.Proceso.Proceso getProceso(int id, ref string mensaje)
        {
            Entidades.Proceso.Proceso proceso = new Entidades.Proceso.Proceso();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getProceso";
            sql.Comando.Parameters.AddWithValue("@IdProceso", id);

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    proceso = Entidades.Proceso.Proceso.CreateProcesoFromDataRecord(reader);
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

            return proceso;
        }

 
        public void insertProceso(Entidades.Proceso.Proceso proceso, string usuario, ref string mensaje)
        {
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_insertProceso";
            sql.Comando.Parameters.AddWithValue("@IdProceso", proceso.IdProceso);
            sql.Comando.Parameters.AddWithValue("@CodigoProceso", proceso.CodigoProceso = proceso.TipoCorrespondencia = (proceso.TipoCorrespondencia == "Comunicados")? "COM": "ISO"); 
            sql.Comando.Parameters.AddWithValue("@TipoCorrespondencia", proceso.TipoCorrespondencia);
            sql.Comando.Parameters.AddWithValue("@IdUsuarioOrigen", proceso.IdUsuarioOrigen);
            sql.Comando.Parameters.AddWithValue("@IdUsuarioResponsable", proceso.IdUsuarioResponsable);
            //sql.Comando.Parameters.AddWithValue("@IdUsuarioEjecuta", proceso.IdUsuarioEjecuta);
            sql.Comando.Parameters.AddWithValue("@IdDepartamento", proceso.IdDepartamento);
            sql.Comando.Parameters.AddWithValue("@PorUsuario", proceso.PorUsuario);
            sql.Comando.Parameters.AddWithValue("@PorDepartamento", proceso.PorDepartamento);
            sql.Comando.Parameters.AddWithValue("@TodosUsuarios", proceso.TodosUsuarios);
            sql.Comando.Parameters.AddWithValue("@Detalle", proceso.__Detalle);
            sql.Comando.Parameters.AddWithValue("@FechaCaduca", proceso.FechaCaduca);
            sql.Comando.Parameters.AddWithValue("@EstadoProceso", proceso.EstadoProceso = (proceso.EstadoProceso == 0)? 1 : proceso.EstadoProceso);
            //sql.Comando.Parameters.AddWithValue("@ImagenAdjunta", proceso.ImagenAdjunta);
            //sql.Comando.Parameters.AddWithValue("@BandejaEntradaOrigen", proceso.BandejaEntradaOrigen);
            //sql.Comando.Parameters.AddWithValue("@BandejaSalidaOrigen", proceso.BandejaSalidaOrigen);
            //sql.Comando.Parameters.AddWithValue("@BandejaSalidaDestino", proceso.BandejaSalidaDestino);            
            //sql.Comando.Parameters.AddWithValue("@BandejaEntradaDestino", proceso.BandejaEntradaDestino);          
            //sql.Comando.Parameters.AddWithValue("@BandejaEliminadaDestino", proceso.BandejaEliminadaDestino);
            //sql.Comando.Parameters.AddWithValue("@BandejaEliminadaOrigen", proceso.BandejaEliminadaOrigen);
            //sql.Comando.Parameters.AddWithValue("@BandejaHistorialDestino", proceso.BandejaHistorialDestino);
            //sql.Comando.Parameters.AddWithValue("@BandejaHistorialOrigen", proceso.BandejaHistorialOrigen);
            //sql.Comando.Parameters.AddWithValue("@ConfirmacionLecturaDestino", proceso.ConfirmacionLecturaDestino);
            //sql.Comando.Parameters.AddWithValue("@ConfirmacionLecturaOrigen", proceso.ConfirmacionLecturaOrigen);
            sql.Comando.Parameters.AddWithValue("@EnviaDocumento", proceso.EnviaDocumento);
            //sql.Comando.Parameters.AddWithValue("@Reverso", proceso.Reverso);
            //sql.Comando.Parameters.AddWithValue("@Estado", proceso.Estado);            
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

        public void updateProceso(Entidades.Proceso.Proceso proceso, string usuario, ref string mensaje)
        {
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_updateEstado";
            sql.Comando.Parameters.AddWithValue("@IdProceso", proceso.IdProceso);
            sql.Comando.Parameters.AddWithValue("@CodigoProceso", proceso.CodigoProceso);
            sql.Comando.Parameters.AddWithValue("@TipoCorrespondencia", proceso.TipoCorrespondencia);
            sql.Comando.Parameters.AddWithValue("@IdUsuarioOrigen", proceso.IdUsuarioOrigen);
            sql.Comando.Parameters.AddWithValue("@IdUsuarioResponsable", proceso.IdUsuarioResponsable);
            sql.Comando.Parameters.AddWithValue("@IdUsuarioEjecuta", proceso.IdUsuarioEjecuta);
            sql.Comando.Parameters.AddWithValue("@IdDepartamento", proceso.IdDepartamento);
            sql.Comando.Parameters.AddWithValue("@PorUsuario", proceso.PorUsuario);
            sql.Comando.Parameters.AddWithValue("@PorDepartamento", proceso.PorDepartamento);
            sql.Comando.Parameters.AddWithValue("@TodosUsuarios", proceso.TodosUsuarios);
            sql.Comando.Parameters.AddWithValue("@Detalle", proceso.__Detalle);
            sql.Comando.Parameters.AddWithValue("@FechaCaduca", proceso.FechaCaduca);
            sql.Comando.Parameters.AddWithValue("@EstadoProceso", proceso.EstadoProceso);
            sql.Comando.Parameters.AddWithValue("@ImagenAdjunta", proceso.ImagenAdjunta);
            sql.Comando.Parameters.AddWithValue("@BandejaEntradaOrigen", proceso.BandejaEntradaOrigen);
            sql.Comando.Parameters.AddWithValue("@BandejaSalidaOrigen", proceso.BandejaSalidaOrigen);
            sql.Comando.Parameters.AddWithValue("@BandejaSalidaDestino", proceso.BandejaSalidaDestino);            
            sql.Comando.Parameters.AddWithValue("@BandejaEntradaDestino", proceso.BandejaEntradaDestino);          
            sql.Comando.Parameters.AddWithValue("@BandejaEliminadaDestino", proceso.BandejaEliminadaDestino);
            sql.Comando.Parameters.AddWithValue("@BandejaEliminadaOrigen", proceso.BandejaEliminadaOrigen);
            sql.Comando.Parameters.AddWithValue("@BandejaHistorialDestino", proceso.BandejaHistorialDestino);
            sql.Comando.Parameters.AddWithValue("@BandejaHistorialOrigen", proceso.BandejaHistorialOrigen);
            sql.Comando.Parameters.AddWithValue("@ConfirmacionLecturaDestino", proceso.ConfirmacionLecturaDestino);
            sql.Comando.Parameters.AddWithValue("@ConfirmacionLecturaOrigen", proceso.ConfirmacionLecturaOrigen);
            sql.Comando.Parameters.AddWithValue("@EnviaDocumento", proceso.EnviaDocumento);
            sql.Comando.Parameters.AddWithValue("@Reverso", proceso.Reverso);
            sql.Comando.Parameters.AddWithValue("@Estado", proceso.Estado);            
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
