using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace TagLogIntelligence.WebAPI.App_Start
{
    public partial class SwaggerFilterAuthorizationToken : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {

            //var vSwaggerAuthorizationTokenAttribute = apiDescription.GetControllerAndActionAttributes<PortalCoreAuthorization>();
            //if (vSwaggerAuthorizationTokenAttribute.Any())
            //{
            //    if (operation.parameters == null)
            //        operation.parameters = new List<Parameter>();

            //    var vVersion = SwaggerConfig.GetVersion(apiDescription);

            //    if (vVersion.Contains("0.0") || vVersion.Contains("1.0"))
            //    {

            //        operation.parameters.Add(new Parameter()
            //        {
            //            name = "Authorization-Token",
            //            @in = "header",
            //            description = "Access Token OLD",
            //            required = false,
            //            type = "string"
            //        });

            //        operation.parameters.Add(new Parameter()
            //        {
            //            name = "App-Id",
            //            @in = "header",
            //            description = "GUID APP ID do Token OLD",
            //            required = false,
            //            type = "string"
            //        });
            //    }

            //    operation.parameters.Add(new Parameter()
            //    {
            //        name = "Authorization",
            //        @in = "header",
            //        description = "OAUTH (Example: 'Bearer TOKEN')",
            //        required = false,
            //        type = "string"
            //    });
            //}

            //var ODataReturnAttribute = apiDescription.GetControllerAndActionAttributes<ODataReturnAttribute>();
            //if (ODataReturnAttribute.Any())
            //{
            //    if (operation.parameters == null)
            //        operation.parameters = new List<Parameter>();

            //    operation.parameters.Add(new Parameter()
            //    {
            //        name = "$top",
            //        @in = "query",
            //        description = "",
            //        required = false,
            //        type = "integer"
            //    });

            //    operation.parameters.Add(new Parameter()
            //    {
            //        name = "$skip",
            //        @in = "query",
            //        description = "",
            //        required = false,
            //        type = "integer"
            //    });

            //    operation.parameters.Add(new Parameter()
            //    {
            //        name = "$filter",
            //        @in = "query",
            //        description = "",
            //        required = false,
            //        type = "string"
            //    });

            //    operation.parameters.Add(new Parameter()
            //    {
            //        name = "$orderby",
            //        @in = "query",
            //        description = "",
            //        required = false,
            //        type = "string"
            //    });

            //    operation.parameters.Add(new Parameter()
            //    {
            //        name = "$count",
            //        @in = "query",
            //        description = "",
            //        required = false,
            //        type = "boolean"
            //    });

            //    operation.parameters.Add(new Parameter()
            //    {
            //        name = "$select",
            //        @in = "query",
            //        description = "",
            //        required = false,
            //        type = "string"
            //    });

            //    operation.parameters.Add(new Parameter()
            //    {
            //        name = "$expand",
            //        @in = "query",
            //        description = "",
            //        required = false,
            //        type = "string"
            //    });

            //    operation.parameters.Add(new Parameter()
            //    {
            //        name = "$apply",
            //        @in = "query",
            //        description = "",
            //        required = false,
            //        type = "string"
            //    });
            //}



            var SwaggerParameterAttribute = apiDescription.GetControllerAndActionAttributes<SwaggerParameterAttribute>();
            if (SwaggerParameterAttribute.Any())
            {
                if (operation.parameters == null)
                    operation.parameters = new List<Parameter>();

                foreach (var P in SwaggerParameterAttribute)
                {
                    operation.parameters.Add(new Parameter()
                    {
                        name = P.name,
                        @in = P.@in,
                        description = P.description,
                        required = P.required,
                        type = P.type
                    });
                }
            }
            if (operation.parameters == null)
                operation.parameters = new List<Parameter>();

            operation.parameters.Add(new Parameter()
            {
                name = "Authorization",
                @in = "header",
                description = "OAUTH (Example: 'Bearer TOKEN')",
                required = false,
                type = "string"
            });


        }


    }
}