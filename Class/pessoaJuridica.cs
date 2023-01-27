using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontro_Remoto_2.Interfaces;

namespace Encontro_Remoto_2.Class
{
    public class pessoaJuridica : Pessoa, InterPessoaJuridica
    {
        public string? cnpj{get; set;}

        public string? razaoSocial{get; set;}

        public override float? calcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarCNPJ(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}