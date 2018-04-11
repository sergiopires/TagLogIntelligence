using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLogIntelligence.Domain;
using TagLogIntelligence.Domain.Models;
using TagLogIntelligence.Repository;
using AutoMapper;
using System.Collections;

namespace TagLogIntelligence.Business
{
    public class Documents
    {
        private Arq_Vip_Rep _arq_Rep;

        public void InserirRegistros(ArquivoVip arqVip)
        {
            var arq = Mapper.Map<ArquivoVip, ARQUIVO_VIP>(arqVip);

            _arq_Rep.Inserir(arq);

        }

        public IEnumerable ObterRegistros()
        {
            return _arq_Rep.lstArquivo();
        }

        public Documents()
        {
            _arq_Rep = new Arq_Vip_Rep();

        }
    }
}
