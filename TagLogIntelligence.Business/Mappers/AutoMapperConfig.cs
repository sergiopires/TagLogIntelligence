using AutoMapper;

using TagLogIntelligence.Domain.Models;
using TagLogIntelligence.Domain;

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
