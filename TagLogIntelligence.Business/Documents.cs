using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLogIntelligence.Domain;
using TagLogIntelligence.Domain.Models;
using TagLogIntelligence.Repository;
using AutoMapper;

namespace TagLogIntelligence.Business
{
    public class Documents
    {
        private Arq_Vip_Rep Arq_Rep = new Arq_Vip_Rep();

        public void InserirRegistros(ArquivoVip arqVip)
        {
          var arq =  Mapper.Map<ArquivoVip,ARQUIVO_VIP>(arqVip);
          
            Arq_Rep.Inserir(arq);
            
        }
    }
}
