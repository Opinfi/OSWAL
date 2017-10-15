using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Administracion
{
    public class TipoCorrespondencia
    {
        [Required]
        [DisplayName("Tipo Correspondencia")]
        [MaxLength(20, ErrorMessage = "El identificador del tipo de correspondencia debe tener máximo 20 caracteres")]
        public string TipoCorrespondenciaId { get; set; }
        [Required]
        [DisplayName("Codigo Correspondencia")]
        [MaxLength(20, ErrorMessage = "El código del tipo de correspondencia debe tener máximo 20 caracteres")]
        public string CodigoCorrespondencia { get; set; }

        [Required]
        [DisplayName("Descripcion")]
        [MaxLength(50, ErrorMessage = "La descripción del tipo de correspondencia debe tener máximo 50 caracteres")]
        public string Descripcion { get; set; }
       
        [DisplayName("Estado")]
        public bool Estado { get; set; }

        public static TipoCorrespondencia CreateTipoCorrespondenciaFromDataRecord(IDataRecord dr)
        {
            TipoCorrespondencia tipoCorrespondencia = new TipoCorrespondencia();

            tipoCorrespondencia.TipoCorrespondenciaId = dr["TipoCorrespondencia"].ToString();
            tipoCorrespondencia.CodigoCorrespondencia = dr["CodigoCorrespondencia"].ToString();
            tipoCorrespondencia.Descripcion = dr["Descripcion"].ToString();
            tipoCorrespondencia.Estado = bool.Parse(dr["Estado"].ToString());

            return tipoCorrespondencia;
        }

    }
}
