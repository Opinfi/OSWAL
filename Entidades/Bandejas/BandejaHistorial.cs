using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bandejas
{
    public class BandejaHistorial
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
        public bool BandejaHistorialOrigen { get; set; }
        public bool BandejaHistorialDestino { get; set; }
        public bool EnviaDocumento { get; set; }
        public bool Estado { get; set; }


        public static BandejaHistorial CreateBandejaHistorialFromDataRecord(IDataRecord dr)
        {
            BandejaHistorial procesosHistorial = new BandejaHistorial();
            procesosHistorial.IdProceso = int.Parse(dr["IdProceso"].ToString());
            procesosHistorial.CodigoProceso = dr["CodigoProceso"].ToString();
            procesosHistorial.TipoCorrespondencia = dr["TipoCorrespondencia"].ToString();
            procesosHistorial.IdUsuarioOrigen = int.Parse(dr["IdUsuarioOrigen"].ToString());
            procesosHistorial.IdUsuarioResponsable = int.Parse(dr["IdUsuarioResponsable"].ToString());
           
            procesosHistorial.IdDepartamento = int.Parse(dr["IdDepartamento"].ToString());
          
            procesosHistorial.Detalle = dr["Asunto"].ToString();
            procesosHistorial.FechaCaduca = DateTime.Parse(dr["FechaCaduca"].ToString());

            if (dr["Foto"] != DBNull.Value)
                procesosHistorial.ImagenAdjunta = (byte[])(dr["Foto"]);

            procesosHistorial.EstadoProceso = int.Parse(dr["EstadoProceso"].ToString());
            
            procesosHistorial.BandejaHistorialDestino = bool.Parse(dr["BandejaHistorialDestino"].ToString());
            procesosHistorial.BandejaHistorialOrigen = bool.Parse(dr["BandejaHistorialOrigen"].ToString());
            
            procesosHistorial.EnviaDocumento = bool.Parse(dr["EnviaDocumento"].ToString());
           
            procesosHistorial.Estado = bool.Parse(dr["Estado"].ToString());

            return procesosHistorial;
        }
    }
}
