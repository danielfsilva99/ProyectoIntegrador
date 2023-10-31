using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Modelo.Repositorio;
using Servicio.Repositorio;
using System.Reflection;

public class Startup
{
    // Otras configuraciones de servicios

    public void ConfigureServices(IServiceCollection services)
    {
        // Otras configuraciones de servicios

        // Registra MediatR y configura los ensamblados donde se encuentran los manejadores de solicitudes.
        services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
        services.AddMediatR(typeof(Startup));
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddSingleton<IClienteRepositorio, ClienteRepositorio>();// Asegúrate de incluir el ensamblado que contiene los manejadores de// Asegúrate de incluir la clase Startup o cualquier ensamblado que contenga los manejadores de solicitudes.

        // Otras configuraciones de servicios
    }

    // Resto del código
}
