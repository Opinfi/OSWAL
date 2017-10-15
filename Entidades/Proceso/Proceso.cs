using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Proceso
{
    public class Proceso
    {
        [Required]
        [DisplayName("Proceso")]
        public int IdProceso { get; set; }

        [DisplayName("Código Proceso")]
        [MaxLength(20, ErrorMessage = "El código del proceso debe tener máximo 20 caracteres")]
        public string CodigoProceso { get; set; }

        [Required]
        [DisplayName("Tipo Correspondencia")]
        [MaxLength(20, ErrorMessage = "El tipo de correspondencia del proceso debe tener máximo 20 caracteres")]
        public string TipoCorrespondencia { get; set; }

        [Required]
        [DisplayName("Usuario Origen")]
        public int IdUsuarioOrigen { get; set; }

        
        [DisplayName("Usuario Responsable")]
        public int IdUsuarioResponsable { get; set; }

        
        [DisplayName("Usuario Ejecuta")]
        public int IdUsuarioEjecuta { get; set; }

        [DisplayName("Departamento")]
        public int IdDepartamento { get; set; }

        
        [DisplayName("Por Usuario")]
        public bool PorUsuario { get; set; }

    
        [DisplayName("Por Departamento")]
        public bool PorDepartamento { get; set; }

        [DisplayName("Todos Usuarios")]
        public bool TodosUsuarios { get; set; }

        [Required]
        [DisplayName("Detalle")]
        public string __Detalle { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Fecha Caduca")]
        public Nullable<DateTime> FechaCaduca { get; set; }

        [Required]
        [DisplayName("Estado Proceso")]
        public int EstadoProceso { get; set; }

        [DisplayName("Imagen Adjunta")]
        public byte[] ImagenAdjunta { get; set; }

        [DisplayName("Bandeja Entrada Origen")]
        public bool BandejaEntradaOrigen { get; set; }

        [DisplayName("Bandeja Salida Origen")]
        public bool BandejaSalidaOrigen { get; set; }

        [DisplayName("Bandeja Salida Destino")]
        public bool BandejaSalidaDestino { get; set; }

        [DisplayName("Bandeja Entrada Destino")]
        public bool BandejaEntradaDestino { get; set; }

        [DisplayName("Bandeja Eliminada Destino")]
        public bool BandejaEliminadaDestino { get; set; }

        [DisplayName("Bandeja Eliminada Origen")]
        public bool BandejaEliminadaOrigen { get; set; }

        [DisplayName("Bandeja Historial Destino")]
        public bool BandejaHistorialDestino { get; set; }

        [DisplayName("Bandeja Historial Origen")]
        public bool BandejaHistorialOrigen { get; set; }

        [DisplayName("Confirmación Lectura Destino")]
        public bool ConfirmacionLecturaDestino { get; set; }

        [DisplayName("Confirmación Lectura Origen")]
        public bool ConfirmacionLecturaOrigen { get; set; }

        [Required]
        [DisplayName("Envia Documento")]
        public bool EnviaDocumento { get; set; }

        [DisplayName("Reverso")]
        public bool Reverso { get; set; }

        [DisplayName("Reasignar")]
        public bool Reasignar { get; set; }

        [DisplayName("Estado")]
        public bool Estado { get; set; }



        public static Proceso CreateProcesoFromDataRecord(IDataRecord dr)
        {
            Proceso proceso = new Proceso();
            proceso.IdProceso = int.Parse(dr["IdProceso"].ToString());
            proceso.CodigoProceso = dr["CodigoProceso"].ToString();
            proceso.TipoCorrespondencia = dr["TipoCorrespondencia"].ToString();
            proceso.IdUsuarioOrigen = int.Parse(dr["IdUsuarioOrigen"].ToString());
            proceso.IdUsuarioResponsable = int.Parse(dr["IdUsuarioResponsable"].ToString());
            proceso.IdUsuarioEjecuta = int.Parse(dr["IdUsuarioEjecuta"].ToString());
            proceso.IdDepartamento = int.Parse(dr["IdDepartamento"].ToString());
            proceso.PorUsuario = bool.Parse(dr["PorUsuario"].ToString());
            proceso.PorDepartamento = bool.Parse(dr["PorDepartamento"].ToString());
            proceso.TodosUsuarios = bool.Parse(dr["TodosUsuarios"].ToString());
            proceso.__Detalle = dr["Asunto"].ToString();
            proceso.FechaCaduca = DateTime.Parse(dr["FechaCaduca"].ToString());

            if (dr["Foto"] != DBNull.Value)
                proceso.ImagenAdjunta = (byte[])(dr["Foto"]);
              
            proceso.EstadoProceso = int.Parse(dr["EstadoProceso"].ToString());            
            proceso.BandejaEntradaOrigen = bool.Parse(dr["BandejaEntradaOrigen"].ToString());
            proceso.BandejaSalidaOrigen = bool.Parse(dr["BandejaSalidaOrigen"].ToString());
            proceso.BandejaSalidaDestino= bool.Parse(dr["BandejaSalidaDestino"].ToString());
            proceso.BandejaEntradaDestino = bool.Parse(dr["BandejaEntradaDestino"].ToString());
            proceso.BandejaEliminadaDestino= bool.Parse(dr["BandejaEliminadaDestino"].ToString());
            proceso.BandejaEliminadaOrigen= bool.Parse(dr["BandejaEliminadaOrigen"].ToString());
            proceso.BandejaHistorialDestino =bool.Parse(dr["BandejaHistorialDestino"].ToString());
            proceso.BandejaHistorialOrigen =bool.Parse(dr["BandejaHistorialOrigen"].ToString());
            proceso.ConfirmacionLecturaDestino =bool.Parse(dr["ConfirmacionLecturaDestino"].ToString());
            proceso.ConfirmacionLecturaOrigen =bool.Parse(dr["ConfirmacionLecturaOrigen"].ToString());
            proceso.EnviaDocumento =bool.Parse(dr["EnviaDocumento"].ToString());
            proceso.Reverso =bool.Parse(dr["Reverso"].ToString());
            proceso.Reasignar =bool.Parse(dr["Reasignar"].ToString());
            proceso.Estado = bool.Parse(dr["Estado"].ToString());

            return proceso;
        }

       
        
    }
}
