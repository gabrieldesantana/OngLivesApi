using ONGLIVESAPI.Interfaces;

public static class DependecyContainer 
{
    public static void AddRegisterServices(this IServiceCollection services)
    {
        #region Services
            //Services
            services.AddScoped<IOngService,OngService>();
            services.AddScoped<IVoluntarioService,VoluntarioService>();
            services.AddScoped<IVagaService,VagaService>();
            services.AddScoped<IExperienciaService, ExperienciaService>();
        #endregion

        #region Repository
        services.AddScoped<IOngRepository,OngRepository>();
            services.AddScoped<IVoluntarioRepository,VoluntarioRepository>();
            services.AddScoped<IVagaRepository,VagaRepository>();
            services.AddScoped<IExperienciaRepository, ExperienciaRepository>();
        #endregion
    }
}