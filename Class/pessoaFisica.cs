using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontro_Remoto_2.Interfaces;

namespace Encontro_Remoto_2.Class
{
    public class pessoaFisica : Pessoa, InterPessoaFisica
    {
        public string? cpf{get; set;}

        public string? dataNasc{get; set;}

        public override float? calcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarDatadeNasc(string dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}