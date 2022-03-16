using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace HomeworkTwo.Filters
{
    public class CustomSwaggerFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            //var nonMobileRoutes = swaggerDoc.Paths
            //    .Where(x => !x.Key.ToLower().Contains("NotVisible"))
            //    .ToList();
            ////nonMobileRoutes.ForEach(x => { swaggerDoc.Paths.Remove(x.Key); });
           
            //if there exist NotVisible in SwaggerDoc's path key is removed
            var nonMobileRoutes = swaggerDoc.Paths.SingleOrDefault(x => x.Key.Contains("NotVisible"));
            swaggerDoc.Paths.Remove(nonMobileRoutes.Key);
        }
    }
    
    
}
