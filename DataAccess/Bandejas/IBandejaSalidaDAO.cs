using Entidades.Bandejas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Bandejas
{
    public interface IBandejaSalidaDAO
    {
        List<BandejaSalida> getAllBandejaSalida(ref string mensaje);

        BandejaSalida getBandejaSalida(int id, ref string mensaje);
    }
}
