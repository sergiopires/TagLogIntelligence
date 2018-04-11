using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TagLogIntelligence.Business;

namespace TagLogIntelligence.WebAPI.Controllers
{
    public class DocumentsController : ApiController
    {
        private Documents _documents = new Documents();

        public IHttpActionResult Get()
        {
            var data = _documents.ObterRegistros();
            return Ok(data);
        }

        //Receber um stream e tratar ele como csv
        public IHttpActionResult Post(string file, [FromBody] dynamic fileContent)
        {
            if (string.IsNullOrWhiteSpace(file))
                throw new ArgumentNullException("file");

            // var data = _fileResponse.SaveSchema(versionType, json);
            return Ok();
        }

    }

}
