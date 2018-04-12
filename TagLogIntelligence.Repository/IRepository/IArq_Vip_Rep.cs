using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLogIntelligence.Domain;

namespace TagLogIntelligence.Repository.IRepository
{
    public interface IArq_Vip_Rep
    {
        IEnumerable<ARQUIVO_VIP> lstArquivo();
        void Atualizar(ARQUIVO_VIP arq_vip);
        void InserirVips(List<ARQUIVO_VIP> arq_vip);
        void Excluir(Int32 id);
    }
}
