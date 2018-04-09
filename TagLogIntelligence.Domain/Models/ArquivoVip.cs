using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagLogIntelligence.Domain.Models
{
    public class ArquivoVip
    {

        public ARQUIVO_VIP ArqVip { get; set; }
        public IEnumerable<ARQUIVO_VIP> ArqVips { get; set; }
    }
}
