using Entidades.Bandejas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Bandejas
{
    public interface IBandejaEliminacionDAO
    {
        List<BandejaEliminacion> getAllBandejaEliminacion(ref string mensaje);

        BandejaEliminacion getBandejaEliminacion(int id, ref string mensaje);
    }
}
