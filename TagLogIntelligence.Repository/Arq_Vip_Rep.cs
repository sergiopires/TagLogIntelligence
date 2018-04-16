using System;
using System.Collections.Generic;
using TagLogIntelligence.DataAccess;
using TagLogIntelligence.Domain;
using TagLogIntelligence.Repository.IRepository;
using System.Linq;

namespace TagLogIntelligence.Repository
{
    public class Arq_Vip_Rep : IArq_Vip_Rep
    {
     
        public void Atualizar(ARQUIVO_VIP arq_vip)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void InserirVips(List<ARQUIVO_VIP> arq_vip)
        {
            using (var conexao = new Conexao())
            {
                foreach (var item in arq_vip)
                {                    
                    conexao.ArquivoVips.Add(item);                
                }
                conexao.SaveChanges();


            }
        }

        public IEnumerable<ARQUIVO_VIP> lstArquivo()
        {
            throw new NotImplementedException();
        }
       
    }
}

