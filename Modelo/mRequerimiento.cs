﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class mRequerimiento
    {
        public Int32 Id_Req { get; set; }
        public readonly bool Estado;
        public readonly DateTime Fecha = DateTime.Now;

    /* public override string ToString()
     {
         return this.Id_Req;
     }*/
}
}
