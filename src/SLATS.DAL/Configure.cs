using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using Slats.Models;
using Slats.DAL;
using System.Windows;

namespace Slats.DAL

{
    public static class Configure
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            ////Context lifetime defaults to "scoped"
            services
                 .AddDbContext<DbContextGeneral>(options => options.UseSqlite(connectionString));

            services
                .AddScoped<IPersonsRepository, PersonsRepository>()
                .AddScoped<ICprPoolsRepository, CprPoolsRepository>()
                .AddScoped<IProviderRepository, ProviderRepository>()
                .AddScoped<IMedPrivilegeProfRepository, MedPrivilegeProfRepository>()
                .AddScoped<IMedPrivilegeRepository, MedPrivilegeRepository>()
                .AddScoped<IRepository<Position>, AtomicRepository<Position>>();
            //    .AddScoped<IRepository<Product>, AtomicRepository<Product>>()
            //    .AddScoped<ISalesPersonRepository, SalesPersonRepository>()
            //    .AddScoped<ITrackingRepository<SalesGroup>, TrackingRepository<SalesGroup>>();
            //MessageBox.Show("Configure Called");

            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IProviderService, ProviderService>();
            services.AddTransient<IProviderService, ProviderService>();
            services.AddTransient<IMedPrivilegeProfService, MedPrivilegeProfService>();
            //services.AddTransient<ISalesPersonService, SalesPersonService>();

            //services.AddTransient<IUserNotifier>((IServiceProvider serviceProvider) =>
            //{
            //    var configuration = serviceProvider.GetService<IConfiguration>();
            //    if (configuration.GetValue<bool>("UseTestUserNotifier"))
            //        return new TestUserNotifier();
            //    else
            //        return new EmailUserNotifier();
            //});

            DbContextGeneral _context = new DbContextGeneral();

            // this is for demo purposes only, to make it easier
            // to get up and running
          //  _context.Database.EnsureCreated();
        }
    }
}