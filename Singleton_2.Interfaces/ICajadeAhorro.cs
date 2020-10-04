using Singleton_2.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_2.Interfaces
{
    public interface ICajadeAhorro
    {
        void Alta(CajadeAhorro cajadeAhorro);
        void Baja(CajadeAhorro cajadeAhorro);
        void Modificar(CajadeAhorro cajadeAhorro);
        IEnumerable<CajadeAhorro> ListarCajadeAhorro();
    }
}
