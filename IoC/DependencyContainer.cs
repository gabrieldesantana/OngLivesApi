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
        #endregion

        #region Repository
            services.AddScoped<IVoluntarioRepository,VoluntarioRepository>();
        #endregion
    }
}