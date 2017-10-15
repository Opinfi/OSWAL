using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bandejas
{
    public class BandejaEntrada
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
        public string Detalle {get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCaduca { get; set; }
        public int EstadoProceso { get; set; }
        public byte[] ImagenAdjunta { get; set; }
        public bool BandejaSalidaOrigen { get; set; }
        public bool BandejaEntradaDestino { get; set; }
        public bool ConfirmacionLecturaDestino { get; set; }
        public bool EnviaDocumento { get; set; }
        public bool Estado { get; set; }
        public static BandejaEntrada CreateBandejaEntradaFromDataRecord(IDataRecord dr)
        {
            BandejaEntrada procesosentrada = new BandejaEntrada();
            procesosentrada.IdProceso = int.Parse(dr["IdProceso"].ToString());
            procesosentrada.CodigoProceso = dr["CodigoProceso"].ToString();
            procesosentrada.TipoCorrespondencia = dr["TipoCorrespondencia"].ToString();
            procesosentrada.IdUsuarioOrigen = int.Parse(dr["IdUsuarioOrigen"].ToString());
            procesosentrada.IdUsuarioResponsable = int.Parse(dr["IdUsuarioResponsable"].ToString());
          
            procesosentrada.IdDepartamento = int.Parse(dr["IdDepartamento"].ToString());
            
            procesosentrada.Detalle = dr["Asunto"].ToString();
            procesosentrada.FechaCaduca = DateTime.Parse(dr["FechaCaduca"].ToString());

            if (dr["Foto"] != DBNull.Value)
                procesosentrada.ImagenAdjunta = (byte[])(dr["Foto"]);

            procesosentrada.EstadoProceso = int.Parse(dr["EstadoProceso"].ToString());
            
            procesosentrada.BandejaSalidaOrigen = bool.Parse(dr["BandejaSalidaOrigen"].ToString());
            
            procesosentrada.BandejaEntradaDestino = bool.Parse(dr["BandejaEntradaDestino"].ToString());
           
            procesosentrada.ConfirmacionLecturaDestino = bool.Parse(dr["ConfirmacionLecturaDestino"].ToString());
            
            procesosentrada.EnviaDocumento = bool.Parse(dr["EnviaDocumento"].ToString());
            
            procesosentrada.Estado = bool.Parse(dr["Estado"].ToString());

            return procesosentrada;
        }
    }
}
