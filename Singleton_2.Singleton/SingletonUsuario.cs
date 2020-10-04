using Singleton_2.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_2.Singleton
{
    public class SingletonUsuario
    {
        private static  SingletonUsuario _singletonUsuario;
        public Usuario Usuarios { get; private set; }


        private SingletonUsuario()
        {

        }

        public static SingletonUsuario GetInstance()
        {
            if (_singletonUsuario == null)
            {
                _singletonUsuario = new SingletonUsuario();
            }
            return _singletonUsuario;
        }

        public void AsignarUsuario(Usuario usuario)
        {
            GetInstance().Usuarios = usuario;
        }

    }
}
