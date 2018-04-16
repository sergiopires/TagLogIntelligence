using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagLogIntelligence.Domain.Models
{
    public class ArquivoVip
    {
        public Guid Arq_vip_id { get; set; }
        public String Arq_vip_parametro_evento { get; set; }
        public String Arq_vip_empresa { get; set; }
        public String Arq_vip_nome { get; set; }
        public String Arq_vip_endereco { get; set; }
        public String Arq_vip_nr { get; set; }
        public String Arq_vip_bairro { get; set; }
        public String Arq_vip_complemento { get; set; }
        public String Arq_vip_uf { get; set; }
        public String Arq_vip_cidade { get; set; }
        public String Arq_vip_cep { get; set; }
        public DateTime Arq_data_importacao { get; set; }
    }
}
