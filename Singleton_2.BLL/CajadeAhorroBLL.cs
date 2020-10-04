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
    public class CajadeAhorroBLL : ICajadeAhorro
    {
        private IList<CajadeAhorro> cajadeAhorrosLista = new List<CajadeAhorro>();

        public void Alta(CajadeAhorro cajadeAhorro)
        {
            cajadeAhorro.UsuarioAsignado = SingletonUsuario.GetInstance().Usuarios.NombreUsuario; 
            cajadeAhorrosLista.Add(cajadeAhorro);
        }

        public void Baja(CajadeAhorro cajadeAhorro)
        {
            cajadeAhorrosLista.Remove(cajadeAhorro);
        }

        public IEnumerable<CajadeAhorro> ListarCajadeAhorro()
        {
            return cajadeAhorrosLista.ToList();
        }

        public void Modificar(CajadeAhorro cajadeAhorro)
        {
            throw new NotImplementedException();
        }
    }
}
