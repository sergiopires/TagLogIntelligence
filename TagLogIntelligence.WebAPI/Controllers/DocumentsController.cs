using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using TagLogIntelligence.Business;
using TagLogIntelligence.Domain.Models;
using TagLogIntelligence.WebAPI.App_Start;

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

        /// <summary>
        /// Método para inserir os registros csv
        /// </summary>
        /// <returns>não retorna</returns>

        [SwaggerParameter(
           name = "CSVFile",
           @in = "formData",
           description = "Csv Stream",
           required = true,
           type = "file"
       )]
        [HttpPost]
        public IHttpActionResult Post()
        {
            System.Web.HttpFileCollection hfc = System.Web.HttpContext.Current.Request.Files;

            if (hfc.Count != 1)
                throw new Exception("method only supports one file at a time");
            HttpPostedFile vFile = hfc[0];

            _documents.InsertDataFileVip(vFile.FileName, vFile.InputStream,vFile.ContentType);

            return Ok("test");


            //if (string.IsNullOrWhiteSpace(fileContent))
            //    throw new ArgumentNullException("file");

            //_documents.InsertDataFileVip(fileContent);

            //// var data = _fileResponse.SaveSchema(versionType, json);
            //return Ok();

            ////if (!Request.Content.IsMimeMultipartContent())
            ////    throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            ////var provider = new MultipartMemoryStreamProvider();
            ////await Request.Content.ReadAsMultipartAsync(provider);
            ////foreach (var file in provider.Contents)
            ////{
            ////    var filename = file.Headers.ContentDisposition.FileName.Trim('\"');
            ////    var buffer = await file.ReadAsByteArrayAsync();
            ////    //Do whatever you want with filename and its binaray data.
            ////}
        }

    }

}
