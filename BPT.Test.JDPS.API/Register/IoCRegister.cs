using BPT.Test.JDPS.Core.Interfaces;
using BPT.Test.JDPS.Core.Services;
using BPT.Test.JDPS.Infraestructure.Data;
using BPT.Test.JDPS.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BPT.Test.JDPS.API.Register
{
    public static class IoCRegister
    {
        /// <summary>
        /// Method to configure services, contexts, repositories and so on
        /// </summary>
        /// <param name="dependence"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddRegistration(IServiceCollection dependence, IConfiguration configuration)
        {
            AddRegisterServices(dependence, configuration);
            AddRegisterRepositories(dependence);
            AddDbContext(dependence, configuration);

            return dependence;
        }

        /// <summary>
        /// Method to add services 
        /// </summary>
        /// <param name="services">Services to configure</param>
        /// <param name="configuration">Auth configuration</param>
        /// <returns>Returns a registered service</returns>
        private static IServiceCollection AddRegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<ISubjectService, SubjectService>();
            //services.AddTransient<IStudentToSubject, StudentToSubject>();

            return services;
        }

        /// <summary>
        /// Method to add repositories
        /// </summary>
        /// <param name="repositories">Repositories to configure</param>
        /// <returns>Returns a registered repository</returns>
        private static IServiceCollection AddRegisterRepositories(IServiceCollection repositories)
        {
            repositories.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            repositories.AddTransient<IUnitOfWork, UnitOfWork>();

            return repositories;
        }

        /// <summary>
        /// Configure new DBContext
        /// </summary>
        /// <param name="services">Service collection to configure</param>
        /// <param name="configuration">DB configuration</param>
        /// <returns></returns>
        private static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TestJDPSDatabaseContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("TestJDPSDatabase"))
            );

            return services;
        }

    }
}
