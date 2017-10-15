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
    public class Departamento
    {
        [Required]
        [DisplayName("Departamento")]
        public int IdDepartamento { get; set; }

        [Required]
        [DisplayName("Codigo")]
        [MaxLength(50, ErrorMessage = "El código del departamento debe tener máximo 50 caracteres")]
        public string Codigo { get; set; }

        [Required]
        [DisplayName("Codigo")]
        [MaxLength(50, ErrorMessage = "La descripción del departamento debe tener máximo 50 caracteres")]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public static Departamento CreateDepartamentoFromDataRecord(IDataRecord dr)
        {
            Departamento departamento = new Departamento();

            departamento.IdDepartamento = int.Parse(dr["IdDepartamento"].ToString());
            departamento.Codigo = dr["Codigo"].ToString();
            departamento.Descripcion = dr["Descripcion"].ToString();
            departamento.Estado = bool.Parse(dr["Estado"].ToString());
         
            return departamento;
        }
    }
}
