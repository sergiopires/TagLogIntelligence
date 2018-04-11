using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TagLogIntelligence.WebAPI.App_Start
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class SwaggerParameterAttribute : Attribute
    {
        public string name;
        public string @in;
        public string description;
        public bool required;
        public string type;


        public SwaggerParameterAttribute()
        {

        }
    }
}