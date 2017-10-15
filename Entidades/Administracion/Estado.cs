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
    public class Estado
    {
        [Required]
        [DisplayName("Estado")]        
        public int idEstado { get; set; }

        [Required]
        [DisplayName("Tipo Estado")]
        [MaxLength(20, ErrorMessage = "El tipo de estado del estado debe tener máximo 20 caracteres")]
        public string idEstadoTipo { get; set; }

        [Required]
        [DisplayName("Código")]        
        [MaxLength(20, ErrorMessage = "El código del estado debe tener máximo 20 caracteres")]
        public string codigo { get; set; }


        [Required]
        [DisplayName("Descripción")]
        [RegularExpression("^[a-zA-Z áéíóúÁÉÍÓÚ]*$", ErrorMessage = "La descripción sólo acepta caracteres alfabéticos")]
        [MaxLength(100, ErrorMessage = "El nombre del estado debe tener máximo 100 caracteres")]
        public string nombre { get; set; }

        [Required]
        [DisplayName("Estado")]
        public bool estado { get; set; }
        

        [Required]
        [DisplayName("Proceso")]
        public bool proceso { get; set; }

        [Required]
        [DisplayName("Documento")]
        public bool documentos { get; set; }

        [DisplayName("Observación")]
        public string observacion { get; set; }




        public static Estado CreateEstadoFromDataRecord(IDataRecord dr)
        {
            Estado estado = new Estado();
            estado.idEstado = int.Parse(dr["idEstado"].ToString());
            estado.codigo = dr["codigo"].ToString();
            estado.idEstadoTipo = dr["idEstadoTipo"].ToString();
            estado.nombre = dr["nombre"].ToString();
            estado.observacion = dr["observacion"].ToString();
            estado.proceso = bool.Parse(dr["proceso"].ToString());
            estado.documentos = bool.Parse(dr["documentos"].ToString());
            estado.estado = bool.Parse(dr["estado"].ToString());
            return estado;

        }

}
}
