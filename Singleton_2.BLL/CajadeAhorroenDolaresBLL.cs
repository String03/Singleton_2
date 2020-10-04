using Singleton_2.EE;
using Singleton_2.Interfaces;
using Singleton_2.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_2.BLL
{
    public class CajadeAhorroenDolaresBLL : ICajadeAhorroenDolares
    {
        private IList<CajadeAhorroenDolares> cajadeAhorroenDolaresLista = new List<CajadeAhorroenDolares>();

        public void Alta(CajadeAhorroenDolares cajadeAhorroenDolares)
        {
            cajadeAhorroenDolares.UsuarioAsignado = SingletonUsuario.GetInstance().Usuarios.NombreUsuario;
            cajadeAhorroenDolaresLista.Add(cajadeAhorroenDolares);
        }

        public void Baja(CajadeAhorroenDolares cajadeAhorroenDolares)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CajadeAhorroenDolares> ListarCajadeAhorroenDolares()
        {
            return cajadeAhorroenDolaresLista.ToList();
        }

        public void Modificar(CajadeAhorroenDolares cajadeAhorroenDolares)
        {
            throw new NotImplementedException();
        }
    }
}
