using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace Elebris.Data.Manager.App_Start
{
    public class AuthorizationOperationFilter : IOperationFilter
    {

        //adds a filter to paste in authorization on swagger. "bearer {insert token, no brackets}"
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }


            operation.parameters.Add(new Parameter

            {
                name = "Authorization",
                @in = "header",
                description = "access token",
                required = false,
                type = "string"
            });
        }
    }
}