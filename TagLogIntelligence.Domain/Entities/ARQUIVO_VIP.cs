using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TagLogIntelligence.Domain
{
    
    public class ARQUIVO_VIP
    {
        [Key]
        public Guid ARQ_VIP_ID { get; set; }
        public String ARQ_VIP_PARAMETRO_EVENTO { get; set; }
        public String ARQ_VIP_EMPRESA { get; set; }
        public String ARQ_VIP_NOME { get; set; }
        public String ARQ_VIP_ENDERECO { get; set; }
        public String ARQ_VIP_NR { get; set; }
        public String ARQ_VIP_BAIRRO { get; set; }
        public String ARQ_VIP_COMPLEMENTO { get; set; }
        public String ARQ_VIP_UF { get; set; }
        public String ARQ_VIP_CIDADE { get; set; }
        public String ARQ_VIP_CEP { get; set; }
        public DateTime ARQ_DATA_IMPORTACAO { get; set; }
    }
}
