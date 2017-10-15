using DataAccess.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Administracion;
using SqlDataAccess.Utils;
using System.Data;

namespace SqlDataAccess.Administracion
{
    public class UsuarioDAO : IUsuarioDAO
    {
        ConsultasSQL sql = new ConsultasSQL();

        public List<Usuario> getAllUsuario(ref string mensaje)
        {
            List<Usuario> usuarios = new List<Usuario>();
            sql = new ConsultasSQL();
            sql.Comando.CommandType = CommandType.StoredProcedure;
            sql.Comando.CommandText = "sp_getListUsuario";

            try
            {
                sql.AbrirConexion();
                IDataReader reader = sql.EjecutaReader(ref mensaje);
                while (reader.Read())
                {
                    usuarios.Add(Usuario.CreateUsuarioFromDataRecord(reader));
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

            return usuarios;
        }

        public Usuario getUsuario(int id, ref string mensaje)
        {
            throw new NotImplementedException();
        }

        public void insertUsuario(Usuario usuarios, string usuario, ref string mensaje)
        {
            throw new NotImplementedException();
        }

        public void updateUsuario(Usuario usuarios, string usuario, ref string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
