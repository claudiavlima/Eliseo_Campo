using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class controladora_Articulos
    {
        private static controladora_Articulos _instancia;

        private controladora_Articulos() { }

        Modelo.ModeloDatosContainer1 oModelo;
        public static controladora_Articulos obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new controladora_Articulos();
            }
            return _instancia;
        }

        public List<Modelo.Articulo> Listar_Articulos()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.ArticuloSet.ToList();
        }

        public System.Collections.IEnumerable OBTENER_ARTICULOS()
        {
            var articulos = from Articulo in oModelo.ArticuloSet.ToList()
                            select Articulo;
            return articulos.ToList();
        }

        /*public System.Collections.IEnumerable LISTAR_PERITOS()
        {

            var peritos = from perito in oEmpresa.PERITOS.Include("Denuncias").ToList()
                          select new { CODIGO = perito.CODIGO_PERITO, NOMBRE = perito.nombre_perito, TELEFONO = perito.telefono_perito, ESPECIALIDAD = perito.especialidad };
            return peritos.ToList();
        }*/


    }
}
