using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bandejas
{
    public class BandejaSalida
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
        public bool BandejaEntradaOrigen { get; set; }
        public bool BandejaSalidaDestino { get; set; }
        public bool ConfirmacionLecturaDestino { get; set; }
        public bool EnviaDocumento { get; set; }
        public bool Estado { get; set; }

        public static BandejaSalida CreateProcesoFromDataRecord(IDataRecord dr)
        {
            BandejaSalida procesoSalida = new BandejaSalida();
            procesoSalida.IdProceso = int.Parse(dr["IdProceso"].ToString());
            procesoSalida.CodigoProceso = dr["CodigoProceso"].ToString();
            procesoSalida.TipoCorrespondencia = dr["TipoCorrespondencia"].ToString();
            procesoSalida.IdUsuarioOrigen = int.Parse(dr["IdUsuarioOrigen"].ToString());
            procesoSalida.IdUsuarioResponsable = int.Parse(dr["IdUsuarioResponsable"].ToString());
           
            procesoSalida.IdDepartamento = int.Parse(dr["IdDepartamento"].ToString());
            
            procesoSalida.Detalle = dr["Asunto"].ToString();
            procesoSalida.FechaCaduca = DateTime.Parse(dr["FechaCaduca"].ToString());

            if (dr["Foto"] != DBNull.Value)
                procesoSalida.ImagenAdjunta = (byte[])(dr["Foto"]);

            procesoSalida.EstadoProceso = int.Parse(dr["EstadoProceso"].ToString());
            procesoSalida.BandejaEntradaOrigen = bool.Parse(dr["BandejaEntradaOrigen"].ToString());
          
            procesoSalida.BandejaSalidaDestino = bool.Parse(dr["BandejaSalidaDestino"].ToString());
           
            procesoSalida.ConfirmacionLecturaDestino = bool.Parse(dr["ConfirmacionLecturaDestino"].ToString());
          
            procesoSalida.EnviaDocumento = bool.Parse(dr["EnviaDocumento"].ToString());
           
            procesoSalida.Estado = bool.Parse(dr["Estado"].ToString());

            return procesoSalida;
        }

    }
}
