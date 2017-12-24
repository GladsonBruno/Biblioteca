using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Biblioteca
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Configurando retorno da api para JSON
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            var jsonFormatter = config.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            config.Formatters.Add(jsonFormatter);

            //Habilitando Cors
            config.EnableCors();

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
