using System;
using System.Collections.Generic;
using TagLogIntelligence.DataAccess;
using TagLogIntelligence.Domain;
using TagLogIntelligence.Repository.IRepository;

namespace TagLogIntelligence.Repository
{
    public class Arq_Vip_Rep : IArq_Vip_Rep
    {
        Conexao conexao;
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
            using (conexao)
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
        public Arq_Vip_Rep()
        {
            conexao = new Conexao();
        }
    }
}

