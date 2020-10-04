using Singleton_2.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_2.Interfaces
{
    public interface ICajadeAhorroenDolares
    {
        void Alta(CajadeAhorroenDolares cajadeAhorroenDolares);
        void Baja(CajadeAhorroenDolares cajadeAhorroenDolares);
        void Modificar(CajadeAhorroenDolares cajadeAhorroenDolares);
        IEnumerable<CajadeAhorroenDolares> ListarCajadeAhorroenDolares();
    }
}
