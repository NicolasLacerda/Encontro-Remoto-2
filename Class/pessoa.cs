using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_Remoto_2.Class
{
    public abstract class Pessoa
    {
        public string? nome {get; set;}
        
        public string? endereco {get; set;}

        public float rendimento {get; set;}

        public abstract float? calcularImposto (float rendimento);

    }
}