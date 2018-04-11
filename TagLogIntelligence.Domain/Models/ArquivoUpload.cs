using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagLogIntelligence.Domain.Models
{
    public class ArquivoUpload
    {
        public string FileName { get; set; }
        public Stream InputStream { get; set; }
        public String ContentType { get; set; }      

    }
}
