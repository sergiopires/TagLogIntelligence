using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TagLogIntelligence.Domain;
using TagLogIntelligence.Domain.Models;

namespace TagLogIntelligence.Business.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
               {
                   x.CreateMap<ArquivoVip, ARQUIVO_VIP>();
               });
        }
    }
}
