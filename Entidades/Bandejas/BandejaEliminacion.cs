using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bandejas
{
    public class BandejaEliminacion
    {
        public int IdProceso { get; set; }
        public string CodigoProceso { get; set; }
        public string TipoCorrespondencia { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuarioOrigen { get; set; }
        public string UsuarioOrigen { get; set; }
        public int IdUsuarioResponsable { get; set; }
        public string UsuarioResponsable { get; set; }
        public int IdDepartamento { get; set; }
        public string Departamento { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCaduca { get; set; }
        public int EstadoProceso { get; set; }
        public byte[] ImagenAdjunta { get; set; }
        public bool BandejaEliminadaOrigen { get; set; }
        public bool EnviaDocumento { get; set; }
        public bool Estado { get; set; }


        public static BandejaEliminacion CreateBandejaEliminacionFromDataRecord(IDataRecord dr)
        {
            BandejaEliminacion procesosEliminados = new BandejaEliminacion();
            procesosEliminados.IdProceso = int.Parse(dr["IdProceso"].ToString());
            procesosEliminados.CodigoProceso = dr["CodigoProceso"].ToString();
            procesosEliminados.TipoCorrespondencia = dr["TipoCorrespondencia"].ToString();
            procesosEliminados.IdUsuarioOrigen = int.Parse(dr["IdUsuarioOrigen"].ToString());
            procesosEliminados.IdUsuarioResponsable = int.Parse(dr["IdUsuarioResponsable"].ToString());
           
            procesosEliminados.IdDepartamento = int.Parse(dr["IdDepartamento"].ToString());
           
            procesosEliminados.Detalle = dr["Asunto"].ToString();
            procesosEliminados.FechaCaduca = DateTime.Parse(dr["FechaCaduca"].ToString());

            if (dr["Foto"] != DBNull.Value)
                procesosEliminados.ImagenAdjunta = (byte[])(dr["Foto"]);

            procesosEliminados.EstadoProceso = int.Parse(dr["EstadoProceso"].ToString());           
            
            procesosEliminados.BandejaEliminadaOrigen = bool.Parse(dr["BandejaEliminadaOrigen"].ToString());
            
            procesosEliminados.EnviaDocumento = bool.Parse(dr["EnviaDocumento"].ToString());
            
            procesosEliminados.Estado = bool.Parse(dr["Estado"].ToString());

            return procesosEliminados;
        }
       }
    }
