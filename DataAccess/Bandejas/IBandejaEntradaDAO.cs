using Entidades.Bandejas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Bandejas
{
    public interface IBandejaEntradaDAO
    {
        List<BandejaEntrada> getAllBandejaEntrada(ref string mensaje);

        BandejaEntrada getBandejaEntrada(int id, ref string mensaje);
    }
}
