using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Diagnostics;

public class MyFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        var typeName = context.Type.Name;
        Debug.WriteLine($"SchemaFilter called with: {typeName}");

        if (typeName == nameof(CoffeeMachine))
        {
            int propertiesCount = schema.Properties.Count;

            Debug.WriteLine($"Properties count of CoffeeMachine: {propertiesCount}");
            // 0 in Swashbuckle.AspNetCore 6.6.1 - Incorrect
            // 1 in Swashbuckle.AspNetCore 6.5.0 - Correct
        }
    }
}

