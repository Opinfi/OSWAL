using Entidades.Bandejas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Bandejas
{
    public interface IBandejaHistorialDAO
    {

        List<BandejaHistorial> getAllBandejaHistorial(ref string mensaje);

        BandejaHistorial getBandejaHistorial(int id, ref string mensaje);
    }
}
