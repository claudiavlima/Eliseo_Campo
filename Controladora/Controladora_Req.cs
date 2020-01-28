using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Controladora_Req
    {
        private static Controladora_Req _instancia;

        private Controladora_Req() { }

        public static Controladora_Req obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new Controladora_Req();
            }
            return _instancia;
        }

        public List<Modelo.Requerimiento> Listar_Requerimientos()
        {
            return Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.ToList();
        }

        public void Agregar_Requerimiento(Modelo.Requerimiento req)
        {
            Modelo.SingletonContexto.obtener_instancia().Contexto.RequerimientoSet.Add(req);
            Modelo.SingletonContexto.obtener_instancia().Contexto.SaveChanges();
        }
    }
}