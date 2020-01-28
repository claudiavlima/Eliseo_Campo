using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SingletonContexto
    {
        private static SingletonContexto _instancia;
        private static ModeloDatosContainer1 _contexto;

        private SingletonContexto() { }

        public static SingletonContexto obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new SingletonContexto();
                _contexto = new ModeloDatosContainer1();
            }
            return _instancia;
        }

        public ModeloDatosContainer1 Contexto
        {
            get { return _contexto; }
        }
    }
}