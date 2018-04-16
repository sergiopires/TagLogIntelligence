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
using System.IO;
using System.Text.RegularExpressions;
using TagLogIntelligence.Business.Utils;



namespace TagLogIntelligence.Business
{
    public class Documents
    {
        private Arq_Vip_Rep _arq_Rep;

        public void InserirRegistros(ArquivoVip arqVip)
        {
            //var arq = Mapper.Map<ArquivoVip, ARQUIVO_VIP>(arqVip);

            //_arq_Rep.Inserir(arq);

        }

        public IEnumerable ObterRegistros()
        {
            return _arq_Rep.lstArquivo();
        }
        public static string StreamToString(Stream stream)
        {
            stream.Position = 0;
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        public static Stream StringToStream(string src)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(src);
            return new MemoryStream(byteArray);
        }


        public void InsertDataFileVip(string fileName, Stream inputStream, string contentType)
        {
          

            var lstArqVip = new List<ARQUIVO_VIP>();

            List<dynamic> lstVips = new List<dynamic>();

            using (StreamReader rd = new StreamReader(inputStream, Encoding.UTF8, false))
            {
                string linha = null;
                string linhaSemAcento = null;

                while ((linha = rd.ReadLine()) != null)
                {
                    linhaSemAcento = ReplaceAccent.RemoveDiacritics(linha);
                    Regex CSVParser = new Regex(@",(?=(?:[^\""]*\""[^\""]*\"")*(?![^\""]*\""))");
                    String[] Fields = CSVParser.Split(linhaSemAcento);

                    

                    lstVips.Add(Fields);

                }
                rd.Close();
            }

          
            for (int i = 1; i < lstVips.Count; i++)
            {
                if (((string[])lstVips[i]).Length != 1 && ((string[])lstVips[i]).Length == 10)
                {
                    ARQUIVO_VIP arquivoVip = new ARQUIVO_VIP();

                    arquivoVip.ARQ_VIP_ID = Guid.NewGuid();
                    arquivoVip.ARQ_VIP_PARAMETRO_EVENTO = ((string[])lstVips[i])[0];
                    arquivoVip.ARQ_VIP_EMPRESA = ((string[])lstVips[i])[1];
                    arquivoVip.ARQ_VIP_NOME = ((string[])lstVips[i])[2];
                    arquivoVip.ARQ_VIP_ENDERECO = ((string[])lstVips[i])[3];
                    arquivoVip.ARQ_VIP_NR = ((string[])lstVips[i])[4];
                    arquivoVip.ARQ_VIP_BAIRRO = ((string[])lstVips[i])[5];
                    arquivoVip.ARQ_VIP_COMPLEMENTO = ((string[])lstVips[i])[6];
                    arquivoVip.ARQ_VIP_UF = ((string[])lstVips[i])[7];
                    arquivoVip.ARQ_VIP_CIDADE = ((string[])lstVips[i])[8];
                    arquivoVip.ARQ_VIP_CEP = ((string[])lstVips[i])[9];
                    arquivoVip.ARQ_DATA_IMPORTACAO = DateTime.Now;

                    lstArqVip.Add(arquivoVip);
                }

            }

            _arq_Rep.InserirVips(lstArqVip);



        }





        public Documents()
        {
            _arq_Rep = new Arq_Vip_Rep();

        }
    }
}
